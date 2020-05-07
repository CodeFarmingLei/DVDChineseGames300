using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using System.IO;

namespace DVD中文游戏300
{
    public partial class FormOption : CCSkinMain
    {
        string AppConfig = null;                        //程序配置文件路径
        string EmuRoute = null;                         //模拟器路径
        string GameRoute = null;                      //游戏ROM路径         
        string GameRecord = null;                   //游戏记录保存文件名

        public FormOption()
        {
            InitializeComponent();
        }

        private void FormOption_Load(object sender, EventArgs e)
        {
            LoadConfig();
        }

        //读取配置文件信息
        public void LoadConfig()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (File.Exists("AppConfig.xml"))
            {
                xmlDoc.Load("AppConfig.xml");   //加载xml文件
                XmlNode xNode = xmlDoc.SelectSingleNode("appSettings");   //读取配置节点
                foreach (XmlNode node in xNode)
                {
                    if (node.SelectSingleNode("spVoiceSound").InnerText.Trim() == "true")
                    {
                        skinCheckBoxSound.Checked = true;
                    }
                    else if (node.SelectSingleNode("spVoiceSound").InnerText.Trim() == "false")
                    {
                        skinCheckBoxSound.Checked = false;
                    }
                    AppConfig = node.SelectSingleNode("AppConfig").InnerText.Trim();
                    skinWaterTextBoxAppConfig.Text = AppConfig;
                    EmuRoute = node.SelectSingleNode("EmuRoute").InnerText.Trim();
                    skinWaterTextBoxEmuRoute.Text = EmuRoute;
                    GameRoute = node.SelectSingleNode("GameRoute").InnerText.Trim();
                    skinWaterTextBoxGameRoute.Text = GameRoute;
                    GameRecord = node.SelectSingleNode("GameRecord").InnerText.Trim();
                    skinWaterTextBoxGameRecord.Text = GameRecord;
                }
            }
            else
            {
                MessageBox.Show("本次程序启动失败，错误原因：\n\n未在目录中找到程序配置文件：AppConfig.xml \n\n请重新安装此程序以解决问题。", "程序启动错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        //保存配置文件信息
        public void SaveConfig()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("AppConfig.xml");   //加载xml文件

            XmlNode xNode = xmlDoc.SelectSingleNode("appSettings");   //读取配置节点
            foreach (XmlNode node in xNode)
            {
                if (skinCheckBoxSound.Checked == true)
                {
                    node.SelectSingleNode("spVoiceSound").InnerText = "true";
                }
                else if (skinCheckBoxSound.Checked == false)
                {
                    node.SelectSingleNode("spVoiceSound").InnerText = "false";
                }
                node.SelectSingleNode("AppConfig").InnerText = skinWaterTextBoxAppConfig.Text;
                node.SelectSingleNode("EmuRoute").InnerText = skinWaterTextBoxEmuRoute.Text;
                node.SelectSingleNode("GameRoute").InnerText = skinWaterTextBoxGameRoute.Text;
                node.SelectSingleNode("GameRecord").InnerText = skinWaterTextBoxGameRecord.Text;
            }
            xmlDoc.Save("AppConfig.xml");
            MessageBox.Show("软件设置保存成功!!","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void SkinButtonSave_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void SkinButtonEmuRoute_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogEmuRoute.ShowDialog() == DialogResult.OK)
            {
                this.skinWaterTextBoxEmuRoute.Text = folderBrowserDialogEmuRoute.SelectedPath;
            }
            folderBrowserDialogEmuRoute.Dispose();

            if (openFileDialogEmuRoute.ShowDialog() == DialogResult.OK)
            {
                this.skinWaterTextBoxEmuRoute.Text = skinWaterTextBoxEmuRoute.Text + @"\" + openFileDialogEmuRoute.SafeFileName;
            }
            openFileDialogEmuRoute.Dispose();
        }

        private void SkinButtonGameRoute_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogGameRoute.ShowDialog() == DialogResult.OK)
            {
                this.skinWaterTextBoxGameRoute.Text = folderBrowserDialogGameRoute.SelectedPath;
            }
            folderBrowserDialogGameRoute.Dispose();
        }
    }
}
