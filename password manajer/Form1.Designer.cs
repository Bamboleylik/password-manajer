namespace password_manajer
{
    partial class Form1
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
            rbGenerate = new RadioButton();
            rbCheck = new RadioButton();
            chkLetters = new CheckBox();
            chkNumbers = new CheckBox();
            chkSymbols = new CheckBox();
            txtPassword = new TextBox();
            btnGenerate = new Button();
            btnSave = new Button();
            numLength = new NumericUpDown();
            lblStrength = new Label();
            picStrength = new PictureBox();
            lstHistory = new ListBox();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            btnCopy = new Button();
            pbStrength = new ProgressBar();
            btnDelete = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)numLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStrength).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rbGenerate
            // 
            rbGenerate.AutoSize = true;
            rbGenerate.Location = new Point(795, 36);
            rbGenerate.Name = "rbGenerate";
            rbGenerate.Size = new Size(156, 24);
            rbGenerate.TabIndex = 0;
            rbGenerate.TabStop = true;
            rbGenerate.Text = "generate password";
            rbGenerate.UseVisualStyleBackColor = true;
            // 
            // rbCheck
            // 
            rbCheck.AutoSize = true;
            rbCheck.Location = new Point(795, 91);
            rbCheck.Name = "rbCheck";
            rbCheck.Size = new Size(187, 24);
            rbCheck.TabIndex = 1;
            rbCheck.TabStop = true;
            rbCheck.Text = "check password stength";
            rbCheck.UseVisualStyleBackColor = true;
            // 
            // chkLetters
            // 
            chkLetters.AutoSize = true;
            chkLetters.Location = new Point(805, 165);
            chkLetters.Name = "chkLetters";
            chkLetters.Size = new Size(124, 24);
            chkLetters.TabIndex = 2;
            chkLetters.Text = "include letters";
            chkLetters.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            chkNumbers.AutoSize = true;
            chkNumbers.Location = new Point(805, 211);
            chkNumbers.Name = "chkNumbers";
            chkNumbers.Size = new Size(140, 24);
            chkNumbers.TabIndex = 3;
            chkNumbers.Text = "include numbers";
            chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkSymbols
            // 
            chkSymbols.AutoSize = true;
            chkSymbols.Location = new Point(805, 266);
            chkSymbols.Name = "chkSymbols";
            chkSymbols.Size = new Size(191, 24);
            chkSymbols.TabIndex = 4;
            chkSymbols.Text = "include specific symbols";
            chkSymbols.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(248, 33);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(188, 27);
            txtPassword.TabIndex = 5;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(227, 121);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(78, 68);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(346, 121);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 70);
            btnSave.TabIndex = 7;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // numLength
            // 
            numLength.Location = new Point(805, 324);
            numLength.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numLength.Name = "numLength";
            numLength.Size = new Size(146, 27);
            numLength.TabIndex = 9;
            // 
            // lblStrength
            // 
            lblStrength.AutoSize = true;
            lblStrength.Location = new Point(80, 33);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new Size(50, 20);
            lblStrength.TabIndex = 10;
            lblStrength.Text = "label1";
            // 
            // picStrength
            // 
            picStrength.Location = new Point(12, 91);
            picStrength.Name = "picStrength";
            picStrength.Size = new Size(209, 229);
            picStrength.TabIndex = 11;
            picStrength.TabStop = false;
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.ItemHeight = 20;
            lstHistory.Location = new Point(227, 248);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(241, 144);
            lstHistory.TabIndex = 12;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1090, 26);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(151, 20);
            statusLabel.Text = "toolStripStatusLabel1";
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(486, 121);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(90, 70);
            btnCopy.TabIndex = 14;
            btnCopy.Text = "copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // pbStrength
            // 
            pbStrength.Location = new Point(486, 21);
            pbStrength.Name = "pbStrength";
            pbStrength.Size = new Size(213, 39);
            pbStrength.TabIndex = 15;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(486, 281);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 70);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(609, 121);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(90, 70);
            btnLoad.TabIndex = 17;
            btnLoad.Text = "load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(pbStrength);
            Controls.Add(btnCopy);
            Controls.Add(statusStrip1);
            Controls.Add(lstHistory);
            Controls.Add(picStrength);
            Controls.Add(lblStrength);
            Controls.Add(numLength);
            Controls.Add(btnSave);
            Controls.Add(btnGenerate);
            Controls.Add(txtPassword);
            Controls.Add(chkSymbols);
            Controls.Add(chkNumbers);
            Controls.Add(chkLetters);
            Controls.Add(rbCheck);
            Controls.Add(rbGenerate);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStrength).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbGenerate;
        private RadioButton rbCheck;
        private CheckBox chkLetters;
        private CheckBox chkNumbers;
        private CheckBox chkSymbols;
        private TextBox txtPassword;
        private Button btnGenerate;
        private Button btnSave;
        private NumericUpDown numLength;
        private Label lblStrength;
        private PictureBox picStrength;
        private ListBox lstHistory;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private Button btnCopy;
        private ProgressBar pbStrength;
        private Button btnDelete;
        private Button btnLoad;
    }
}