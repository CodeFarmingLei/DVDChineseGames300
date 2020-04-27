using CCWin;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace DVD中文游戏300
{
    public partial class FormMain : CCSkinMain
    {
        //游戏菜单显示计数器
        int GameMenuIndex = 1;
        //游戏页数计数器
        int GameChapterIndex = 1;
        //模拟器路径
        string emu = null;
        //游戏ROM路径
        string game = null;
        //游戏记录保存文件名
        string strPath = @"E:\VCD300NesGames\GameRecord.xml";
        //记录当前选中的游戏文件
        string gameId = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Game_Click(object sender, EventArgs e)
        {
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AppConfig();
        }

        //初始化配置加载
        public void AppConfig()
        {
            skinTabControl1.SelectedTab = skinTabPage1;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"E:\VCD300NesGames\AppConfig.xml");   //加载xml文件

            XmlNode xns = xmlDoc.SelectSingleNode("appSettings");   //读取配置节点

            emu = xns.ChildNodes[2].InnerText;
            game = xns.ChildNodes[3].InnerText;

            if (xns.ChildNodes[0].InnerText == "true")
            {
                Thread thread = new Thread(spVoice);
                thread.Start();
            }

            GetXmlInfo();
        }

        //播放欢迎音频
        public void spVoice()
        {
            Type type = Type.GetTypeFromProgID("SAPI.SpVoice");
            dynamic spVoice = Activator.CreateInstance(type);
            spVoice.Speak("欢迎游玩 中文游戏300");
        }

        //切换显示主页面游戏菜单图片
        public void GamesMenuImg()
        {
            if (GameMenuIndex == 0)   //到一页时显示提示信息
            {
                MessageBox.Show("当前已经是第一页", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GameMenuIndex++;
                GameChapterIndex = 1;
            }
            else if (GameMenuIndex == 1)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第1页;
                GameChapterIndex = 1;
            }
            else if (GameMenuIndex == 2)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第2页;
                GameChapterIndex = 2;
            }
            else if (GameMenuIndex == 3)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第3页;
                GameChapterIndex = 3;
            }
            else if (GameMenuIndex == 4)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第4页;
                GameChapterIndex = 4;
            }
            else if (GameMenuIndex == 5)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第5页;
                GameChapterIndex = 5;
            }
            else if (GameMenuIndex == 6)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第6页;
                GameChapterIndex = 6;
            }
            else if (GameMenuIndex == 7)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第7页;
                GameChapterIndex = 7;
            }
            else if (GameMenuIndex == 8)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第8页;
                GameChapterIndex = 8;
            }
            else if (GameMenuIndex == 9)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第9页;
                GameChapterIndex = 9;
            }
            else if (GameMenuIndex == 10)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第10页;
                GameChapterIndex = 10;
            }
            else if (GameMenuIndex == 11)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第11页;
                GameChapterIndex = 11;
            }
            else if (GameMenuIndex == 12)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第12页;
                GameChapterIndex = 12;
            }
            else if (GameMenuIndex == 13)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第13页;
                GameChapterIndex = 13;
            }
            else if (GameMenuIndex == 14)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第14页;
                GameChapterIndex = 14;
            }
            else if (GameMenuIndex == 15)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第15页;
                GameChapterIndex = 15;
            }
            else if (GameMenuIndex == 16)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第16页;
                GameChapterIndex = 16;
            }
            else if (GameMenuIndex == 17)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第17页;
                GameChapterIndex = 17;
            }
            else if (GameMenuIndex == 18)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第18页;
                GameChapterIndex = 18;
            }
            else if (GameMenuIndex == 19)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第19页;
                GameChapterIndex = 19;
            }
            else if (GameMenuIndex == 20)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第20页;
                GameChapterIndex = 20;
            }
            else if (GameMenuIndex == 21)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第21页;
                GameChapterIndex = 21;
            }
            else if (GameMenuIndex == 22)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第22页;
                GameChapterIndex = 22;
            }
            else if (GameMenuIndex == 23)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第23页;
                GameChapterIndex = 23;
            }
            else if (GameMenuIndex == 24)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第24页;
                GameChapterIndex = 24;
            }
            else if (GameMenuIndex == 25)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第25页;
                GameChapterIndex = 25;
            }
            else if (GameMenuIndex == 26)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第26页;
                GameChapterIndex = 26;
            }
            else if (GameMenuIndex == 27)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第27页;
                GameChapterIndex = 27;
            }
            else if (GameMenuIndex == 28)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第28页;
                GameChapterIndex = 28;
            }
            else if (GameMenuIndex == 29)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第29页;
                GameChapterIndex = 29;
            }
            else if (GameMenuIndex == 30)
            {
                PictureBoxGame.Image = DVD中文游戏300.ResourceImg.第30页;
                GameChapterIndex = 30;
            }
            else if (GameMenuIndex == 31)   //到最后一页时显示提示信息
            {
                MessageBox.Show("当前已经是最后一页", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GameMenuIndex--;
                GameChapterIndex = 30;
            }
        }

        //增加游戏次数、保存到xml、刷新DataGridView显示
        public void GameCountUp()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(strPath);   //加载xml文件

            XmlNode xns = xmlDoc.SelectSingleNode("GameRecord");   //查找要修改的节点
            foreach (XmlNode xn in xns)
            {
                XmlElement element = (XmlElement)xn;
                if (element.GetAttribute("id") == gameId)
                {
                    int count = Convert.ToInt32(element.GetAttribute("count"));
                    count++;   //次数加1
                    element.SetAttribute("count", count.ToString());
                    break;
                }
            }
            xmlDoc.Save(strPath);
            GetXmlInfo();   //刷新主控件显示
        }

        //读取xml文件数据填充到DataGridView
        public void GetXmlInfo()
        {
            skinDataGridView1.AutoGenerateColumns = false;  //禁止自动创建列
            DataSet myds = new DataSet();
            myds.ReadXml(strPath);
            skinDataGridView1.DataSource = myds.Tables[0];
        }

        /*==============================================================*/

        //上一页
        private void SkinButtonLeft_Click(object sender, EventArgs e)
        {
            GameMenuIndex--;    //游戏菜单计数器减1
            GamesMenuImg();     //调用切换显示主页面游戏菜单图片方法
        }

        //下一页
        private void SkinButtonRight_Click(object sender, EventArgs e)
        {
            GameMenuIndex++;    //游戏菜单计数器加1
            GamesMenuImg();     //调用切换显示主页面游戏菜单图片方法
        }

        //确定选择
        private void SkinButtonOK_Click(object sender, EventArgs e)
        {
            GameMenuIndex = (int)numericUpDownMenuIndex.Value;
            GamesMenuImg();     //调用切换显示主页面游戏菜单图片方法
        }

        //运行游戏
        private void SkinButtonReady_Click(object sender, EventArgs e)
        {
            string gameIndex = numericUpDownGameIndex.Value.ToString();
            string Rungame = game + @"\" + GameChapterIndex + "-" + gameIndex+ ".nes";
            gameId = GameChapterIndex + "-" + gameIndex;    //设置当前选择的游戏名
            GameCountUp();
            System.Diagnostics.Process.Start(emu, Rungame);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否退出本程序？？", "确认退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                this.FormClosing -= new FormClosingEventHandler(this.FormMain_FormClosing);
                Application.Exit();
            }
        }

        private void 模拟器设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string emu = @"E:\VCD300NesGames\Emulator\VirtuaNES.exe";
            System.Diagnostics.Process.Start(emu);

            Thread thread = new Thread(MessageBoxShow);
            thread.Start();
        }

        //弹出对话框
        public void MessageBoxShow()
        {
            MessageBox.Show("模拟器启动后点击顶部的 选项 按钮即可进行相应的设置", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void 软件设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOption FormOption = new FormOption();
            FormOption.Show();
        }

        private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开使用说明窗口
            FormHelp FormHelp = new FormHelp();
            FormHelp.Show();
        }

        private void 更新日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开更新日志窗口
            FormUpdateLog FormUpdateLog = new FormUpdateLog();
            FormUpdateLog.Show();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开关于程序窗口
            FormAbout FormAbout = new FormAbout();
            FormAbout.Show();
        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            //打开关于程序窗口
            FormAbout FormAbout = new FormAbout();
            FormAbout.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否退出本程序？？", "确认退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                this.FormClosing -= new FormClosingEventHandler(this.FormMain_FormClosing);
                Application.Exit();
            }
            else if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
