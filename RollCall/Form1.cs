using Sunny.UI;
using System.Speech.Synthesis;

namespace RollCall
{
    public partial class Form1 : UIForm
    {
        //�洢ѧ������
        private List<string> studentName = new List<string>();

        //����ѧ������ ֵ����Ӧѧ�������İ�ť
        private Dictionary<string, UIButton> stuBtns = new Dictionary<string, UIButton>();
        //��ȡ��ѧ���±�
        int index = -1;
        //�Ƿ��Զ�����
        bool b = false;
        public Form1()
        {
            InitializeComponent();
            //ȡ���̷߳���
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// ��ȡ����
        /// </summary>
        private void ReadName()
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();

            try
            {
                if (string.IsNullOrEmpty(studentName[index]))
                {
                    speech.Speak("����������");
                }
                else
                {
                    speech.Speak(studentName[index]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"����:{ex?.Message}");
            }
        }

        /// <summary>
        /// ����Զ����� ���Ż�����ͣ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (b)
            {
                btnStart.Text = "�����Զ�����";
                b = !b;
                btnReset.Enabled = true;
                btnSetFile.Enabled = true;
                UpperOrLower();
            }
            else
            {
                btnStart.Text = "��ͣ�Զ�����";
                b = !b;
                btnLower.Enabled = false;
                btnReset.Enabled = false;
                btnUpper.Enabled = false;
                btnSetFile.Enabled = false;
                
                Task.Run(() =>
                {
                    while (b)
                    {
                        if (index != studentName.Count - 1)
                        {
                            index++;
                            SetBtnStyle();
                            ReadName();
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            btnStart.Text = "��ʼ�Զ�����";
                            stuBtns[studentName[index]].Style = UIStyle.Blue;
                            b = !b;
                            btnReset.Enabled = true;
                            index = -1;
                            UpperOrLower();
                        }
                    }
                });
            }
        }

        /// <summary>
        /// �ı䰴ť��ʽ
        /// </summary>
        private void SetBtnStyle()
        {
            foreach (KeyValuePair<string, UIButton> item in stuBtns)
            {
                stuBtns[item.Key].Style = UIStyle.Blue;
            }
            stuBtns[studentName[index]].Style = UIStyle.Red;
        }

        /// <summary>
        /// ���ش���ʱ ��������ѧ����Ϣ��ť
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            stuBtns = new Dictionary<string, UIButton>();
            studentName = new List<string>();
            plStudent.Controls.Clear();
            index = -1;
            b=false;

            btnUpper.Enabled = false;
            string line;

            StreamReader file = new StreamReader("StudenName.txt");
            int x = 0;
            int y = 0;
            while ((line = file.ReadLine()) != null)
            {
                UIButton btn = new UIButton();
                btn.Text = line;
                btn.Tag = studentName.Count;
                btn.Size = new Size(125, 44);

                btn.Location = new Point(20 + 155 * x, 20 + y * 64);
                btn.Click += btnName_Click;
                if (x == 5)
                {
                    x = 0;
                    y++;
                }
                else
                {
                    x++;
                }

                plStudent.Controls.Add(btn);
                studentName.Add(line);
                stuBtns.Add(line, btn);
            }

            file.Close();
        }

        /// <summary>
        /// ������һ������һ����ť
        /// </summary>
        private void UpperOrLower()
        {
            if (index != 0 && index != -1)
            {
                btnUpper.Enabled = true;
            }
            else
            {
                btnUpper.Enabled = false;
            }
            if (index != studentName.Count - 1)
            {
                btnLower.Enabled = true;
            }
            else
            {
                btnLower.Enabled = false;
            }
        }

        /// <summary>
        /// ������һ��ѧ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpper_Click(object sender, EventArgs e)
        {
            if (index == 0)
            {
                btnUpper.Enabled = false;
                return;
            }
            Task.Run(() =>
            {
                --index;
                UpperOrLower();
                SetBtnStyle();
                ReadName();
            });


        }

        /// <summary>
        /// ������һ��ѧ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLower_Click(object sender, EventArgs e)
        {

            if (index == studentName.Count - 1)
            {
                btnLower.Enabled = false;
            }
            Task.Run(() =>
            {
                index++;
                UpperOrLower();
                SetBtnStyle();
                ReadName();
            });
        }

        /// <summary>
        /// ���²��ŵ�ǰѧ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {


            Task.Run(() =>
            {
                try
                {
                    SetBtnStyle();
                    ReadName();
                }
                catch
                {
                }
            });
        }

        /// <summary>
        /// ���ѧ��������ť ���Ÿ�ѧ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnName_Click(object sender, EventArgs e)
        {
            UIButton btn = (UIButton)sender;
            int i = studentName.FindIndex(x => x.Equals(btn.Text));
            index = i;
            SetBtnStyle();
            UpperOrLower();
            Task.Run(() =>
            {
                ReadName();
            });
        }

        /// <summary>
        /// ���������ļ���Ϣ ���ļ���Ϣд�뵽StudenName.txt��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "�ı��ļ�|*.txt";
            ofd.FilterIndex = 1;
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fileInfo = ofd.FileName;
                StreamReader file = new StreamReader(fileInfo);
                StreamWriter writer = new StreamWriter("StudenName.txt");
                string line = "";
                string lines = "";
                while ((line = file.ReadLine()) != null)
                {
                    lines += line + "\r\n";
                }
                writer.Write(lines);
                writer.Close();
                file.Close();
                Form1_Load(sender, e);
            }
        }
    }
}