namespace PascherDaten
{
    partial class PADaten
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabCnt = new System.Windows.Forms.TabControl();
            this.tabCntCopy = new System.Windows.Forms.TabPage();
            this.lbtotalFilevalue = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbPerzentage = new System.Windows.Forms.Label();
            this.procBar = new System.Windows.Forms.ProgressBar();
            this.lbUntil = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.dateTimePickerTil = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.cmboxScenario = new System.Windows.Forms.ComboBox();
            this.lbTimeSelect = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnDstPath = new System.Windows.Forms.Button();
            this.btnSrcPath = new System.Windows.Forms.Button();
            this.txtBoxDstPath = new System.Windows.Forms.TextBox();
            this.txtboxSrcPath = new System.Windows.Forms.TextBox();
            this.lbDestPath = new System.Windows.Forms.Label();
            this.lbSourcePath = new System.Windows.Forms.Label();
            this.tabcntDelete = new System.Windows.Forms.TabPage();
            this.progBarDel = new System.Windows.Forms.ProgressBar();
            this.btnRunDel = new System.Windows.Forms.Button();
            this.dateTimePickerDTil = new System.Windows.Forms.DateTimePicker();
            this.lbTimeselectorD = new System.Windows.Forms.Label();
            this.btnPathSeletor = new System.Windows.Forms.Button();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.lbPath = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabCnt.SuspendLayout();
            this.tabCntCopy.SuspendLayout();
            this.tabcntDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCnt
            // 
            this.tabCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCnt.Controls.Add(this.tabCntCopy);
            this.tabCnt.Controls.Add(this.tabcntDelete);
            this.tabCnt.Location = new System.Drawing.Point(2, 1);
            this.tabCnt.Name = "tabCnt";
            this.tabCnt.SelectedIndex = 0;
            this.tabCnt.Size = new System.Drawing.Size(380, 277);
            this.tabCnt.TabIndex = 0;
            this.tabCnt.SelectedIndexChanged += new System.EventHandler(this.tabCnt_SelectedIndexChanged);
            // 
            // tabCntCopy
            // 
            this.tabCntCopy.Controls.Add(this.lbtotalFilevalue);
            this.tabCntCopy.Controls.Add(this.lbTotal);
            this.tabCntCopy.Controls.Add(this.lbPerzentage);
            this.tabCntCopy.Controls.Add(this.procBar);
            this.tabCntCopy.Controls.Add(this.lbUntil);
            this.tabCntCopy.Controls.Add(this.lbFrom);
            this.tabCntCopy.Controls.Add(this.dateTimePickerTil);
            this.tabCntCopy.Controls.Add(this.dateTimePickerFrom);
            this.tabCntCopy.Controls.Add(this.cmboxScenario);
            this.tabCntCopy.Controls.Add(this.lbTimeSelect);
            this.tabCntCopy.Controls.Add(this.btnRun);
            this.tabCntCopy.Controls.Add(this.btnDstPath);
            this.tabCntCopy.Controls.Add(this.btnSrcPath);
            this.tabCntCopy.Controls.Add(this.txtBoxDstPath);
            this.tabCntCopy.Controls.Add(this.txtboxSrcPath);
            this.tabCntCopy.Controls.Add(this.lbDestPath);
            this.tabCntCopy.Controls.Add(this.lbSourcePath);
            this.tabCntCopy.Location = new System.Drawing.Point(4, 24);
            this.tabCntCopy.Name = "tabCntCopy";
            this.tabCntCopy.Padding = new System.Windows.Forms.Padding(3);
            this.tabCntCopy.Size = new System.Drawing.Size(372, 249);
            this.tabCntCopy.TabIndex = 0;
            this.tabCntCopy.Text = "Kopieren";
            this.tabCntCopy.UseVisualStyleBackColor = true;
            // 
            // lbtotalFilevalue
            // 
            this.lbtotalFilevalue.AutoSize = true;
            this.lbtotalFilevalue.Location = new System.Drawing.Point(148, 184);
            this.lbtotalFilevalue.Name = "lbtotalFilevalue";
            this.lbtotalFilevalue.Size = new System.Drawing.Size(0, 15);
            this.lbtotalFilevalue.TabIndex = 14;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(10, 184);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(134, 15);
            this.lbTotal.TabIndex = 13;
            this.lbTotal.Text = "Gesamtzahl der Dateien:";
            // 
            // lbPerzentage
            // 
            this.lbPerzentage.AutoSize = true;
            this.lbPerzentage.Location = new System.Drawing.Point(109, 231);
            this.lbPerzentage.Name = "lbPerzentage";
            this.lbPerzentage.Size = new System.Drawing.Size(49, 15);
            this.lbPerzentage.TabIndex = 12;
            this.lbPerzentage.Text = "0/100 %";
            // 
            // procBar
            // 
            this.procBar.Location = new System.Drawing.Point(10, 207);
            this.procBar.Name = "procBar";
            this.procBar.Size = new System.Drawing.Size(239, 23);
            this.procBar.TabIndex = 11;
            // 
            // lbUntil
            // 
            this.lbUntil.AutoSize = true;
            this.lbUntil.Location = new System.Drawing.Point(10, 156);
            this.lbUntil.Name = "lbUntil";
            this.lbUntil.Size = new System.Drawing.Size(22, 15);
            this.lbUntil.TabIndex = 10;
            this.lbUntil.Text = "Bis";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(10, 118);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(27, 15);
            this.lbFrom.TabIndex = 9;
            this.lbFrom.Text = "Von";
            // 
            // dateTimePickerTil
            // 
            this.dateTimePickerTil.Enabled = false;
            this.dateTimePickerTil.Location = new System.Drawing.Point(84, 151);
            this.dateTimePickerTil.Name = "dateTimePickerTil";
            this.dateTimePickerTil.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerTil.TabIndex = 8;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Enabled = false;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(82, 110);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerFrom.TabIndex = 7;
            // 
            // cmboxScenario
            // 
            this.cmboxScenario.AutoCompleteCustomSource.AddRange(new string[] {
            "all",
            "last 7 days"});
            this.cmboxScenario.FormattingEnabled = true;
            this.cmboxScenario.Items.AddRange(new object[] {
            "Heute",
            "Letzten 7 Tage",
            "Letzten 14 Tage",
            "Letzten 30 Tage",
            "Letzten 45 Tage",
            "Benutzerdefiniert"});
            this.cmboxScenario.Location = new System.Drawing.Point(139, 73);
            this.cmboxScenario.Name = "cmboxScenario";
            this.cmboxScenario.Size = new System.Drawing.Size(172, 23);
            this.cmboxScenario.TabIndex = 6;
            this.cmboxScenario.Text = "Heute";
            this.cmboxScenario.SelectedIndexChanged += new System.EventHandler(this.cmboxScenario_SelectedIndexChanged);
            // 
            // lbTimeSelect
            // 
            this.lbTimeSelect.AutoSize = true;
            this.lbTimeSelect.Location = new System.Drawing.Point(10, 78);
            this.lbTimeSelect.Name = "lbTimeSelect";
            this.lbTimeSelect.Size = new System.Drawing.Size(116, 15);
            this.lbTimeSelect.TabIndex = 5;
            this.lbTimeSelect.Text = "schnelle Zeitauswahl";
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.AutoSize = true;
            this.btnRun.Location = new System.Drawing.Point(283, 206);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(71, 25);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Kopieren";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnDstPath
            // 
            this.btnDstPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDstPath.AutoSize = true;
            this.btnDstPath.Location = new System.Drawing.Point(341, 38);
            this.btnDstPath.Name = "btnDstPath";
            this.btnDstPath.Size = new System.Drawing.Size(26, 25);
            this.btnDstPath.TabIndex = 4;
            this.btnDstPath.Text = "...";
            this.btnDstPath.Click += new System.EventHandler(this.btnDstPath_Click);
            // 
            // btnSrcPath
            // 
            this.btnSrcPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSrcPath.AutoSize = true;
            this.btnSrcPath.Location = new System.Drawing.Point(340, 9);
            this.btnSrcPath.Name = "btnSrcPath";
            this.btnSrcPath.Size = new System.Drawing.Size(26, 25);
            this.btnSrcPath.TabIndex = 4;
            this.btnSrcPath.Text = "...";
            this.btnSrcPath.Click += new System.EventHandler(this.btnSrcPath_Click);
            // 
            // txtBoxDstPath
            // 
            this.txtBoxDstPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDstPath.Location = new System.Drawing.Point(84, 39);
            this.txtBoxDstPath.Name = "txtBoxDstPath";
            this.txtBoxDstPath.Size = new System.Drawing.Size(252, 23);
            this.txtBoxDstPath.TabIndex = 3;
            // 
            // txtboxSrcPath
            // 
            this.txtboxSrcPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxSrcPath.Location = new System.Drawing.Point(84, 9);
            this.txtboxSrcPath.Name = "txtboxSrcPath";
            this.txtboxSrcPath.Size = new System.Drawing.Size(252, 23);
            this.txtboxSrcPath.TabIndex = 2;
            // 
            // lbDestPath
            // 
            this.lbDestPath.AutoSize = true;
            this.lbDestPath.Location = new System.Drawing.Point(10, 44);
            this.lbDestPath.Name = "lbDestPath";
            this.lbDestPath.Size = new System.Drawing.Size(26, 15);
            this.lbDestPath.TabIndex = 1;
            this.lbDestPath.Text = "Ziel";
            // 
            // lbSourcePath
            // 
            this.lbSourcePath.AutoSize = true;
            this.lbSourcePath.Location = new System.Drawing.Point(10, 10);
            this.lbSourcePath.Name = "lbSourcePath";
            this.lbSourcePath.Size = new System.Drawing.Size(56, 15);
            this.lbSourcePath.TabIndex = 0;
            this.lbSourcePath.Text = "Ursprung";
            // 
            // tabcntDelete
            // 
            this.tabcntDelete.Controls.Add(this.progBarDel);
            this.tabcntDelete.Controls.Add(this.btnRunDel);
            this.tabcntDelete.Controls.Add(this.dateTimePickerDTil);
            this.tabcntDelete.Controls.Add(this.lbTimeselectorD);
            this.tabcntDelete.Controls.Add(this.btnPathSeletor);
            this.tabcntDelete.Controls.Add(this.txtBoxPath);
            this.tabcntDelete.Controls.Add(this.lbPath);
            this.tabcntDelete.Location = new System.Drawing.Point(4, 24);
            this.tabcntDelete.Name = "tabcntDelete";
            this.tabcntDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabcntDelete.Size = new System.Drawing.Size(372, 249);
            this.tabcntDelete.TabIndex = 1;
            this.tabcntDelete.Text = "Löschen";
            this.tabcntDelete.UseVisualStyleBackColor = true;
            // 
            // progBarDel
            // 
            this.progBarDel.Location = new System.Drawing.Point(54, 160);
            this.progBarDel.Name = "progBarDel";
            this.progBarDel.Size = new System.Drawing.Size(250, 23);
            this.progBarDel.TabIndex = 7;
            // 
            // btnRunDel
            // 
            this.btnRunDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunDel.Location = new System.Drawing.Point(268, 206);
            this.btnRunDel.Name = "btnRunDel";
            this.btnRunDel.Size = new System.Drawing.Size(71, 25);
            this.btnRunDel.TabIndex = 0;
            this.btnRunDel.Text = "Löschen !!";
            this.btnRunDel.Click += new System.EventHandler(this.btnRunDel_Click);
            // 
            // dateTimePickerDTil
            // 
            this.dateTimePickerDTil.Location = new System.Drawing.Point(60, 93);
            this.dateTimePickerDTil.Name = "dateTimePickerDTil";
            this.dateTimePickerDTil.Size = new System.Drawing.Size(205, 23);
            this.dateTimePickerDTil.TabIndex = 6;
            // 
            // lbTimeselectorD
            // 
            this.lbTimeselectorD.AutoSize = true;
            this.lbTimeselectorD.Location = new System.Drawing.Point(10, 57);
            this.lbTimeselectorD.Name = "lbTimeselectorD";
            this.lbTimeselectorD.Size = new System.Drawing.Size(203, 15);
            this.lbTimeselectorD.TabIndex = 2;
            this.lbTimeselectorD.Text = "alle Dateien mit Änderungsdatum bis";
            // 
            // btnPathSeletor
            // 
            this.btnPathSeletor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPathSeletor.Location = new System.Drawing.Point(310, 9);
            this.btnPathSeletor.Name = "btnPathSeletor";
            this.btnPathSeletor.Size = new System.Drawing.Size(36, 23);
            this.btnPathSeletor.TabIndex = 0;
            this.btnPathSeletor.Text = "...";
            this.btnPathSeletor.Click += new System.EventHandler(this.btnPathSeletor_Click);
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPath.Location = new System.Drawing.Point(60, 9);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(244, 23);
            this.txtBoxPath.TabIndex = 1;
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(10, 9);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(44, 15);
            this.lbPath.TabIndex = 0;
            this.lbPath.Text = "Ordner";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PADaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 280);
            this.Controls.Add(this.tabCnt);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(400, 319);
            this.Name = "PADaten";
            this.Text = "AP Daten";
            this.Load += new System.EventHandler(this.PADaten_Load);
            this.tabCnt.ResumeLayout(false);
            this.tabCntCopy.ResumeLayout(false);
            this.tabCntCopy.PerformLayout();
            this.tabcntDelete.ResumeLayout(false);
            this.tabcntDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCnt;
        private System.Windows.Forms.TabPage tabCntCopy;
        private System.Windows.Forms.TabPage tabcntDelete;
        private System.Windows.Forms.Label lbSourcePath;
        private System.Windows.Forms.TextBox txtBoxDstPath;
        private System.Windows.Forms.TextBox txtboxSrcPath;
        private System.Windows.Forms.Label lbDestPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSrcPath;
        private System.Windows.Forms.Button btnDstPath;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox cmboxScenario;
        private System.Windows.Forms.Label lbTimeSelect;
        private System.Windows.Forms.Label lbUntil;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTil;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btnPathSeletor;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Button btnRunDel;
        private System.Windows.Forms.DateTimePicker dateTimePickerDTil;
        private System.Windows.Forms.Label lbTimeselectorD;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ProgressBar procBar;
        private System.Windows.Forms.Label lbPerzentage;
        private System.Windows.Forms.Label lbtotalFilevalue;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.ProgressBar progBarDel;
    }
}

