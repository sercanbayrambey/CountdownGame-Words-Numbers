namespace CountDownGame
{
    partial class frmMain
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
            this.tabControlMain = new MetroFramework.Controls.MetroTabControl();
            this.tabPageWord = new MetroFramework.Controls.MetroTabPage();
            this.btnGenerateWord = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSelectedLetters = new System.Windows.Forms.Label();
            this.lboxFoundWords = new System.Windows.Forms.ListBox();
            this.tabPageOp = new MetroFramework.Controls.MetroTabPage();
            this.btnGenerateNumbers = new MetroFramework.Controls.MetroButton();
            this.lblSelectedNumbersTitle = new System.Windows.Forms.GroupBox();
            this.lblSelectedNumbers = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOperationSteps = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageWord.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageOp.SuspendLayout();
            this.lblSelectedNumbersTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageWord);
            this.tabControlMain.Controls.Add(this.tabPageOp);
            this.tabControlMain.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tabControlMain.Location = new System.Drawing.Point(23, 63);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 1;
            this.tabControlMain.Size = new System.Drawing.Size(1424, 754);
            this.tabControlMain.TabIndex = 5;
            // 
            // tabPageWord
            // 
            this.tabPageWord.Controls.Add(this.label2);
            this.tabPageWord.Controls.Add(this.btnGenerateWord);
            this.tabPageWord.Controls.Add(this.groupBox1);
            this.tabPageWord.Controls.Add(this.lboxFoundWords);
            this.tabPageWord.HorizontalScrollbarBarColor = true;
            this.tabPageWord.Location = new System.Drawing.Point(4, 35);
            this.tabPageWord.Name = "tabPageWord";
            this.tabPageWord.Size = new System.Drawing.Size(1416, 715);
            this.tabPageWord.TabIndex = 0;
            this.tabPageWord.Text = "Kelime";
            this.tabPageWord.VerticalScrollbarBarColor = true;
            // 
            // btnGenerateWord
            // 
            this.btnGenerateWord.Location = new System.Drawing.Point(902, 297);
            this.btnGenerateWord.Name = "btnGenerateWord";
            this.btnGenerateWord.Size = new System.Drawing.Size(250, 66);
            this.btnGenerateWord.TabIndex = 10;
            this.btnGenerateWord.Text = "Harf Üret";
            this.btnGenerateWord.Click += new System.EventHandler(this.btnGenerateWord_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblSelectedLetters);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(475, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 239);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçili Harfler";
            // 
            // lblSelectedLetters
            // 
            this.lblSelectedLetters.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSelectedLetters.Location = new System.Drawing.Point(6, 29);
            this.lblSelectedLetters.Name = "lblSelectedLetters";
            this.lblSelectedLetters.Size = new System.Drawing.Size(665, 138);
            this.lblSelectedLetters.TabIndex = 5;
            this.lblSelectedLetters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lboxFoundWords
            // 
            this.lboxFoundWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lboxFoundWords.FormattingEnabled = true;
            this.lboxFoundWords.ItemHeight = 24;
            this.lboxFoundWords.Location = new System.Drawing.Point(3, 43);
            this.lboxFoundWords.Name = "lboxFoundWords";
            this.lboxFoundWords.Size = new System.Drawing.Size(466, 532);
            this.lboxFoundWords.TabIndex = 7;
            // 
            // tabPageOp
            // 
            this.tabPageOp.Controls.Add(this.lblOperationSteps);
            this.tabPageOp.Controls.Add(this.richTextBox1);
            this.tabPageOp.Controls.Add(this.btnGenerateNumbers);
            this.tabPageOp.Controls.Add(this.lblSelectedNumbersTitle);
            this.tabPageOp.HorizontalScrollbarBarColor = true;
            this.tabPageOp.Location = new System.Drawing.Point(4, 35);
            this.tabPageOp.Name = "tabPageOp";
            this.tabPageOp.Size = new System.Drawing.Size(1416, 715);
            this.tabPageOp.TabIndex = 1;
            this.tabPageOp.Text = "İşlem";
            this.tabPageOp.VerticalScrollbarBarColor = true;
            // 
            // btnGenerateNumbers
            // 
            this.btnGenerateNumbers.Location = new System.Drawing.Point(902, 292);
            this.btnGenerateNumbers.Name = "btnGenerateNumbers";
            this.btnGenerateNumbers.Size = new System.Drawing.Size(250, 66);
            this.btnGenerateNumbers.TabIndex = 14;
            this.btnGenerateNumbers.Text = "Sayı Üret";
            this.btnGenerateNumbers.Click += new System.EventHandler(this.btnGenerateNumbers_Click);
            // 
            // lblSelectedNumbersTitle
            // 
            this.lblSelectedNumbersTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedNumbersTitle.Controls.Add(this.lblSelectedNumbers);
            this.lblSelectedNumbersTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblSelectedNumbersTitle.Location = new System.Drawing.Point(475, 38);
            this.lblSelectedNumbersTitle.Name = "lblSelectedNumbersTitle";
            this.lblSelectedNumbersTitle.Size = new System.Drawing.Size(677, 239);
            this.lblSelectedNumbersTitle.TabIndex = 13;
            this.lblSelectedNumbersTitle.TabStop = false;
            this.lblSelectedNumbersTitle.Text = "Seçilen Sayılar:";
            // 
            // lblSelectedNumbers
            // 
            this.lblSelectedNumbers.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSelectedNumbers.Location = new System.Drawing.Point(6, 29);
            this.lblSelectedNumbers.Name = "lblSelectedNumbers";
            this.lblSelectedNumbers.Size = new System.Drawing.Size(665, 138);
            this.lblSelectedNumbers.TabIndex = 5;
            this.lblSelectedNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 19.25F);
            this.richTextBox1.Location = new System.Drawing.Point(3, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(466, 542);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bulunan Kelimeler:";
            // 
            // lblOperationSteps
            // 
            this.lblOperationSteps.AutoSize = true;
            this.lblOperationSteps.BackColor = System.Drawing.Color.Transparent;
            this.lblOperationSteps.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOperationSteps.Location = new System.Drawing.Point(3, 13);
            this.lblOperationSteps.Name = "lblOperationSteps";
            this.lblOperationSteps.Size = new System.Drawing.Size(173, 22);
            this.lblOperationSteps.TabIndex = 16;
            this.lblOperationSteps.Text = "İşlem Basamakları:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 840);
            this.Controls.Add(this.tabControlMain);
            this.Name = "frmMain";
            this.Text = "Bir Kelime Bir İşlem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageWord.ResumeLayout(false);
            this.tabPageWord.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPageOp.ResumeLayout(false);
            this.tabPageOp.PerformLayout();
            this.lblSelectedNumbersTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControlMain;
        private MetroFramework.Controls.MetroTabPage tabPageWord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSelectedLetters;
        private System.Windows.Forms.ListBox lboxFoundWords;
        private MetroFramework.Controls.MetroTabPage tabPageOp;
        private MetroFramework.Controls.MetroButton btnGenerateWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOperationSteps;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroButton btnGenerateNumbers;
        private System.Windows.Forms.GroupBox lblSelectedNumbersTitle;
        private System.Windows.Forms.Label lblSelectedNumbers;
    }
}

