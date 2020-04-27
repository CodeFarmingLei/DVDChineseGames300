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

namespace DVD中文游戏300
{
    public partial class FormOption : CCSkinMain
    {
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
            xmlDoc.Load(@"E:\VCD300NesGames\AppConfig.xml");   //加载xml文件

            XmlNode xns = xmlDoc.SelectSingleNode("appSettings");   //查找要修改的节点
            if (xns.ChildNodes[0].InnerText == "true")
            {
                skinCheckBoxSound.Checked = true;
            }
            else if (xns.ChildNodes[0].InnerText == "false")
            {
                skinCheckBoxSound.Checked = false;
            }
            skinWaterTextBoxAppConfig.Text = xns.ChildNodes[1].InnerText;
            skinWaterTextBoxEmuRoute.Text = xns.ChildNodes[2].InnerText;
            skinWaterTextBoxGameRoute.Text = xns.ChildNodes[3].InnerText;
            skinWaterTextBoxGameRecord.Text = xns.ChildNodes[4].InnerText;
        }

        //保存配置文件信息
        public void SaveConfig()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"E:\VCD300NesGames\AppConfig.xml");   //加载xml文件

            XmlNode xns = xmlDoc.SelectSingleNode("appSettings");   //查找要修改的节点
            if (skinCheckBoxSound.Checked == true)
            {
                xns.ChildNodes[0].InnerText = "true";
            }
            else if (skinCheckBoxSound.Checked == false)
            {
                xns.ChildNodes[0].InnerText = "false";
            }
            xns.ChildNodes[1].InnerText = skinWaterTextBoxEmuRoute.Text;
            xns.ChildNodes[2].InnerText = skinWaterTextBoxGameRoute.Text;
            xmlDoc.Save(@"E:\VCD300NesGames\AppConfig.xml");
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
