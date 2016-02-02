namespace blighted_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.dialogueText = new System.Windows.Forms.Label();
            this.settingPicture = new System.Windows.Forms.PictureBox();
            this.tilldeathTimer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            this.option4Label = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.creditLabel = new System.Windows.Forms.Label();
            this.logopicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logopicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(555, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 32);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "...";
            // 
            // dialogueText
            // 
            this.dialogueText.BackColor = System.Drawing.Color.NavajoWhite;
            this.dialogueText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dialogueText.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogueText.ForeColor = System.Drawing.Color.Black;
            this.dialogueText.Location = new System.Drawing.Point(0, 361);
            this.dialogueText.Name = "dialogueText";
            this.dialogueText.Size = new System.Drawing.Size(879, 266);
            this.dialogueText.TabIndex = 2;
            // 
            // settingPicture
            // 
            this.settingPicture.Image = global::blighted_.Properties.Resources.Marsh;
            this.settingPicture.Location = new System.Drawing.Point(0, 0);
            this.settingPicture.Name = "settingPicture";
            this.settingPicture.Size = new System.Drawing.Size(885, 373);
            this.settingPicture.TabIndex = 0;
            this.settingPicture.TabStop = false;
            // 
            // tilldeathTimer
            // 
            this.tilldeathTimer.Interval = 60000;
            this.tilldeathTimer.Tick += new System.EventHandler(this.tilldeathTimer_Tick);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(234, 188);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(394, 247);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // option1Label
            // 
            this.option1Label.AutoSize = true;
            this.option1Label.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.Location = new System.Drawing.Point(12, 9);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(24, 25);
            this.option1Label.TabIndex = 9;
            this.option1Label.Text = "...";
            // 
            // option2Label
            // 
            this.option2Label.AutoSize = true;
            this.option2Label.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.Location = new System.Drawing.Point(12, 117);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(24, 25);
            this.option2Label.TabIndex = 10;
            this.option2Label.Text = "...";
            // 
            // option3Label
            // 
            this.option3Label.AutoSize = true;
            this.option3Label.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.Location = new System.Drawing.Point(12, 228);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(24, 25);
            this.option3Label.TabIndex = 11;
            this.option3Label.Text = "...";
            // 
            // option4Label
            // 
            this.option4Label.AutoSize = true;
            this.option4Label.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option4Label.Location = new System.Drawing.Point(12, 336);
            this.option4Label.Name = "option4Label";
            this.option4Label.Size = new System.Drawing.Size(24, 25);
            this.option4Label.TabIndex = 12;
            this.option4Label.Text = "...";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.inventoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryLabel.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(726, 0);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(153, 361);
            this.inventoryLabel.TabIndex = 13;
            this.inventoryLabel.Text = "Inventory:";
            this.inventoryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::blighted_.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(278, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 75);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.BackColor = System.Drawing.Color.Black;
            this.creditLabel.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.ForeColor = System.Drawing.Color.Red;
            this.creditLabel.Location = new System.Drawing.Point(157, 492);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(108, 51);
            this.creditLabel.TabIndex = 15;
            this.creditLabel.Text = "label1";
            // 
            // logopicBox
            // 
            this.logopicBox.Image = global::blighted_.Properties.Resources.studio_logo;
            this.logopicBox.Location = new System.Drawing.Point(0, 0);
            this.logopicBox.Name = "logopicBox";
            this.logopicBox.Size = new System.Drawing.Size(879, 555);
            this.logopicBox.TabIndex = 16;
            this.logopicBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(879, 627);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.logopicBox);
            this.Controls.Add(this.dialogueText);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.option4Label);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.settingPicture);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Blighted";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.settingPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logopicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox settingPicture;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label dialogueText;
        private System.Windows.Forms.Timer tilldeathTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option3Label;
        private System.Windows.Forms.Label option4Label;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.PictureBox logopicBox;
    }
}

