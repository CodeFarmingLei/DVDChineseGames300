namespace DVD中文游戏300
{
    partial class FormOption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOption));
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.skinWaterTextBoxGameRecord = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabelGameRecord = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBoxSound = new CCWin.SkinControl.SkinGroupBox();
            this.skinCheckBoxSound = new CCWin.SkinControl.SkinCheckBox();
            this.skinButtonSave = new CCWin.SkinControl.SkinButton();
            this.folderBrowserDialogGameRoute = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialogEmuRoute = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogEmuRoute = new System.Windows.Forms.FolderBrowserDialog();
            this.skinWaterTextBoxAppConfig = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabelAppConfig = new CCWin.SkinControl.SkinLabel();
            this.skinButtonGameRoute = new CCWin.SkinControl.SkinButton();
            this.skinButtonEmuRoute = new CCWin.SkinControl.SkinButton();
            this.skinWaterTextBoxGameRoute = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinWaterTextBoxEmuRoute = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabelGameRoute = new CCWin.SkinControl.SkinLabel();
            this.skinLabelEmuRoute = new CCWin.SkinControl.SkinLabel();
            this.skinTabControl1.SuspendLayout();
            this.skinTabPage1.SuspendLayout();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBoxSound.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.skinTabPage1);
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl1.Location = new System.Drawing.Point(7, 31);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.SelectedIndex = 0;
            this.skinTabControl1.Size = new System.Drawing.Size(636, 411);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 0;
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.skinTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinTabPage1.Controls.Add(this.skinGroupBox1);
            this.skinTabPage1.Controls.Add(this.skinGroupBoxSound);
            this.skinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage1.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Size = new System.Drawing.Size(636, 375);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.TabItemImage = null;
            this.skinTabPage1.Text = "基本设置";
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Controls.Add(this.skinButtonGameRoute);
            this.skinGroupBox1.Controls.Add(this.skinButtonEmuRoute);
            this.skinGroupBox1.Controls.Add(this.skinWaterTextBoxGameRoute);
            this.skinGroupBox1.Controls.Add(this.skinWaterTextBoxEmuRoute);
            this.skinGroupBox1.Controls.Add(this.skinLabelGameRoute);
            this.skinGroupBox1.Controls.Add(this.skinLabelEmuRoute);
            this.skinGroupBox1.Controls.Add(this.skinWaterTextBoxAppConfig);
            this.skinGroupBox1.Controls.Add(this.skinLabelAppConfig);
            this.skinGroupBox1.Controls.Add(this.skinWaterTextBoxGameRecord);
            this.skinGroupBox1.Controls.Add(this.skinLabelGameRecord);
            this.skinGroupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox1.Location = new System.Drawing.Point(3, 73);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(628, 158);
            this.skinGroupBox1.TabIndex = 4;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "相关路径设置";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinWaterTextBoxGameRecord
            // 
            this.skinWaterTextBoxGameRecord.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinWaterTextBoxGameRecord.Location = new System.Drawing.Point(135, 60);
            this.skinWaterTextBoxGameRecord.Name = "skinWaterTextBoxGameRecord";
            this.skinWaterTextBoxGameRecord.Size = new System.Drawing.Size(396, 23);
            this.skinWaterTextBoxGameRecord.TabIndex = 8;
            this.skinWaterTextBoxGameRecord.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBoxGameRecord.WaterText = "";
            // 
            // skinLabelGameRecord
            // 
            this.skinLabelGameRecord.AutoSize = true;
            this.skinLabelGameRecord.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelGameRecord.BorderColor = System.Drawing.Color.White;
            this.skinLabelGameRecord.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelGameRecord.ForeColor = System.Drawing.Color.Black;
            this.skinLabelGameRecord.Location = new System.Drawing.Point(10, 60);
            this.skinLabelGameRecord.Name = "skinLabelGameRecord";
            this.skinLabelGameRecord.Size = new System.Drawing.Size(135, 20);
            this.skinLabelGameRecord.TabIndex = 7;
            this.skinLabelGameRecord.Text = "游戏次数记录文件：";
            // 
            // skinGroupBoxSound
            // 
            this.skinGroupBoxSound.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBoxSound.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBoxSound.Controls.Add(this.skinCheckBoxSound);
            this.skinGroupBoxSound.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBoxSound.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBoxSound.Location = new System.Drawing.Point(3, 3);
            this.skinGroupBoxSound.Name = "skinGroupBoxSound";
            this.skinGroupBoxSound.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBoxSound.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBoxSound.Size = new System.Drawing.Size(628, 64);
            this.skinGroupBoxSound.TabIndex = 3;
            this.skinGroupBoxSound.TabStop = false;
            this.skinGroupBoxSound.Text = "声音设置";
            this.skinGroupBoxSound.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBoxSound.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBoxSound.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinCheckBoxSound
            // 
            this.skinCheckBoxSound.AutoSize = true;
            this.skinCheckBoxSound.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxSound.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxSound.DownBack = null;
            this.skinCheckBoxSound.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxSound.ForeColor = System.Drawing.Color.Black;
            this.skinCheckBoxSound.Location = new System.Drawing.Point(40, 25);
            this.skinCheckBoxSound.MouseBack = null;
            this.skinCheckBoxSound.Name = "skinCheckBoxSound";
            this.skinCheckBoxSound.NormlBack = null;
            this.skinCheckBoxSound.SelectedDownBack = null;
            this.skinCheckBoxSound.SelectedMouseBack = null;
            this.skinCheckBoxSound.SelectedNormlBack = null;
            this.skinCheckBoxSound.Size = new System.Drawing.Size(126, 24);
            this.skinCheckBoxSound.TabIndex = 1;
            this.skinCheckBoxSound.Text = "欢迎页提示语音";
            this.skinCheckBoxSound.UseVisualStyleBackColor = false;
            // 
            // skinButtonSave
            // 
            this.skinButtonSave.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.skinButtonSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonSave.DownBack = null;
            this.skinButtonSave.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButtonSave.Location = new System.Drawing.Point(506, 454);
            this.skinButtonSave.MouseBack = null;
            this.skinButtonSave.Name = "skinButtonSave";
            this.skinButtonSave.NormlBack = null;
            this.skinButtonSave.Size = new System.Drawing.Size(135, 33);
            this.skinButtonSave.TabIndex = 1;
            this.skinButtonSave.Text = "保存设置";
            this.skinButtonSave.UseVisualStyleBackColor = false;
            this.skinButtonSave.Click += new System.EventHandler(this.SkinButtonSave_Click);
            // 
            // folderBrowserDialogGameRoute
            // 
            this.folderBrowserDialogGameRoute.Description = "请选择游戏ROM路径";
            this.folderBrowserDialogGameRoute.SelectedPath = "E:\\VCD300NesGames\\Games";
            // 
            // openFileDialogEmuRoute
            // 
            this.openFileDialogEmuRoute.InitialDirectory = "E:\\VCD300NesGames\\Emulator";
            this.openFileDialogEmuRoute.Title = "请选择模拟器启动程序文件";
            // 
            // folderBrowserDialogEmuRoute
            // 
            this.folderBrowserDialogEmuRoute.Description = "请选择模拟器路径";
            this.folderBrowserDialogEmuRoute.SelectedPath = "E:\\VCD300NesGames\\Emulator";
            // 
            // skinWaterTextBoxAppConfig
            // 
            this.skinWaterTextBoxAppConfig.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinWaterTextBoxAppConfig.Location = new System.Drawing.Point(135, 31);
            this.skinWaterTextBoxAppConfig.Name = "skinWaterTextBoxAppConfig";
            this.skinWaterTextBoxAppConfig.Size = new System.Drawing.Size(396, 23);
            this.skinWaterTextBoxAppConfig.TabIndex = 14;
            this.skinWaterTextBoxAppConfig.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBoxAppConfig.WaterText = "";
            // 
            // skinLabelAppConfig
            // 
            this.skinLabelAppConfig.AutoSize = true;
            this.skinLabelAppConfig.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelAppConfig.BorderColor = System.Drawing.Color.White;
            this.skinLabelAppConfig.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelAppConfig.ForeColor = System.Drawing.Color.Black;
            this.skinLabelAppConfig.Location = new System.Drawing.Point(38, 31);
            this.skinLabelAppConfig.Name = "skinLabelAppConfig";
            this.skinLabelAppConfig.Size = new System.Drawing.Size(107, 20);
            this.skinLabelAppConfig.TabIndex = 13;
            this.skinLabelAppConfig.Text = "程序配置文件：";
            // 
            // skinButtonGameRoute
            // 
            this.skinButtonGameRoute.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonGameRoute.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.skinButtonGameRoute.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonGameRoute.DownBack = null;
            this.skinButtonGameRoute.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButtonGameRoute.ForeColor = System.Drawing.Color.Black;
            this.skinButtonGameRoute.Location = new System.Drawing.Point(537, 118);
            this.skinButtonGameRoute.MouseBack = null;
            this.skinButtonGameRoute.Name = "skinButtonGameRoute";
            this.skinButtonGameRoute.NormlBack = null;
            this.skinButtonGameRoute.Size = new System.Drawing.Size(81, 23);
            this.skinButtonGameRoute.TabIndex = 20;
            this.skinButtonGameRoute.Text = "更改路径";
            this.skinButtonGameRoute.UseVisualStyleBackColor = false;
            // 
            // skinButtonEmuRoute
            // 
            this.skinButtonEmuRoute.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonEmuRoute.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.skinButtonEmuRoute.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonEmuRoute.DownBack = null;
            this.skinButtonEmuRoute.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButtonEmuRoute.ForeColor = System.Drawing.Color.Black;
            this.skinButtonEmuRoute.Location = new System.Drawing.Point(537, 89);
            this.skinButtonEmuRoute.MouseBack = null;
            this.skinButtonEmuRoute.Name = "skinButtonEmuRoute";
            this.skinButtonEmuRoute.NormlBack = null;
            this.skinButtonEmuRoute.Size = new System.Drawing.Size(81, 23);
            this.skinButtonEmuRoute.TabIndex = 19;
            this.skinButtonEmuRoute.Text = "更改路径";
            this.skinButtonEmuRoute.UseVisualStyleBackColor = false;
            // 
            // skinWaterTextBoxGameRoute
            // 
            this.skinWaterTextBoxGameRoute.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinWaterTextBoxGameRoute.Location = new System.Drawing.Point(135, 118);
            this.skinWaterTextBoxGameRoute.Name = "skinWaterTextBoxGameRoute";
            this.skinWaterTextBoxGameRoute.Size = new System.Drawing.Size(396, 23);
            this.skinWaterTextBoxGameRoute.TabIndex = 18;
            this.skinWaterTextBoxGameRoute.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBoxGameRoute.WaterText = "";
            // 
            // skinWaterTextBoxEmuRoute
            // 
            this.skinWaterTextBoxEmuRoute.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinWaterTextBoxEmuRoute.Location = new System.Drawing.Point(135, 89);
            this.skinWaterTextBoxEmuRoute.Name = "skinWaterTextBoxEmuRoute";
            this.skinWaterTextBoxEmuRoute.Size = new System.Drawing.Size(396, 23);
            this.skinWaterTextBoxEmuRoute.TabIndex = 17;
            this.skinWaterTextBoxEmuRoute.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBoxEmuRoute.WaterText = "";
            // 
            // skinLabelGameRoute
            // 
            this.skinLabelGameRoute.AutoSize = true;
            this.skinLabelGameRoute.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelGameRoute.BorderColor = System.Drawing.Color.White;
            this.skinLabelGameRoute.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelGameRoute.ForeColor = System.Drawing.Color.Black;
            this.skinLabelGameRoute.Location = new System.Drawing.Point(60, 118);
            this.skinLabelGameRoute.Name = "skinLabelGameRoute";
            this.skinLabelGameRoute.Size = new System.Drawing.Size(85, 20);
            this.skinLabelGameRoute.TabIndex = 16;
            this.skinLabelGameRoute.Text = "游戏ROM：";
            // 
            // skinLabelEmuRoute
            // 
            this.skinLabelEmuRoute.AutoSize = true;
            this.skinLabelEmuRoute.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelEmuRoute.BorderColor = System.Drawing.Color.White;
            this.skinLabelEmuRoute.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelEmuRoute.ForeColor = System.Drawing.Color.Black;
            this.skinLabelEmuRoute.Location = new System.Drawing.Point(80, 89);
            this.skinLabelEmuRoute.Name = "skinLabelEmuRoute";
            this.skinLabelEmuRoute.Size = new System.Drawing.Size(65, 20);
            this.skinLabelEmuRoute.TabIndex = 15;
            this.skinLabelEmuRoute.Text = "模拟器：";
            // 
            // FormOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.skinButtonSave);
            this.Controls.Add(this.skinTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "软件设置";
            this.Load += new System.EventHandler(this.FormOption_Load);
            this.skinTabControl1.ResumeLayout(false);
            this.skinTabPage1.ResumeLayout(false);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.skinGroupBoxSound.ResumeLayout(false);
            this.skinGroupBoxSound.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage skinTabPage1;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxSound;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBoxSound;
        private CCWin.SkinControl.SkinButton skinButtonSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogGameRoute;
        private System.Windows.Forms.OpenFileDialog openFileDialogEmuRoute;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogEmuRoute;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBoxGameRecord;
        private CCWin.SkinControl.SkinLabel skinLabelGameRecord;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBoxAppConfig;
        private CCWin.SkinControl.SkinLabel skinLabelAppConfig;
        private CCWin.SkinControl.SkinButton skinButtonGameRoute;
        private CCWin.SkinControl.SkinButton skinButtonEmuRoute;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBoxGameRoute;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBoxEmuRoute;
        private CCWin.SkinControl.SkinLabel skinLabelGameRoute;
        private CCWin.SkinControl.SkinLabel skinLabelEmuRoute;
    }
}