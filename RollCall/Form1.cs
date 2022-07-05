using Sunny.UI;
using System.Speech.Synthesis;

namespace RollCall
{
    public partial class Form1 : UIForm
    {
        //存储学生姓名
        private List<string> studentName = new List<string>();

        //键：学生姓名 值：对应学生姓名的按钮
        private Dictionary<string, UIButton> stuBtns = new Dictionary<string, UIButton>();
        //读取的学生下标
        int index = -1;
        //是否自动播放
        bool b = false;
        public Form1()
        {
            InitializeComponent();
            //取消线程访问
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 读取名字
        /// </summary>
        private void ReadName()
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();

            try
            {
                if (string.IsNullOrEmpty(studentName[index]))
                {
                    speech.Speak("请输入文字");
                }
                else
                {
                    speech.Speak(studentName[index]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"报错:{ex?.Message}");
            }
        }

        /// <summary>
        /// 点击自动点名 播放或者暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (b)
            {
                btnStart.Text = "继续自动点名";
                b = !b;
                btnReset.Enabled = true;
                btnSetFile.Enabled = true;
                UpperOrLower();
            }
            else
            {
                btnStart.Text = "暂停自动点名";
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
                            btnStart.Text = "开始自动点名";
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
        /// 改变按钮样式
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
        /// 加载窗体时 创建所有学生信息按钮
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
        /// 开关上一个与下一个按钮
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
        /// 播放上一个学生名称
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
        /// 播放下一个学生名称
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
        /// 重新播放当前学生名称
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
        /// 点击学生姓名按钮 播放该学生姓名
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
        /// 将更换的文件信息 将文件信息写入到StudenName.txt中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "文本文件|*.txt";
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