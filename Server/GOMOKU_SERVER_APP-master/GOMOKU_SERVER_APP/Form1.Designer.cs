namespace GOMOKU_SERVER_APP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlLog = new System.Windows.Forms.Panel();
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelSocket = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.ptbMark = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelStatusRival = new System.Windows.Forms.Label();
            this.labelSocketRival = new System.Windows.Forms.Label();
            this.labelNameRival = new System.Windows.Forms.Label();
            this.ptbMarkRival = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelRival = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.lbPlayer = new System.Windows.Forms.ListBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbChat = new System.Windows.Forms.TextBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.pnlLog.SuspendLayout();
            this.pnlInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMark)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMarkRival)).BeginInit();
            this.pnlPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLog
            // 
            this.pnlLog.Controls.Add(this.tbLog);
            this.pnlLog.Location = new System.Drawing.Point(12, 37);
            this.pnlLog.Name = "pnlLog";
            this.pnlLog.Size = new System.Drawing.Size(404, 245);
            this.pnlLog.TabIndex = 0;
            this.pnlLog.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlInformation
            // 
            this.pnlInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInformation.Controls.Add(this.pictureBox1);
            this.pnlInformation.Controls.Add(this.panel1);
            this.pnlInformation.Controls.Add(this.panel2);
            this.pnlInformation.Location = new System.Drawing.Point(568, 40);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(353, 242);
            this.pnlInformation.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = global::GOMOKU_SERVER_APP.Properties.Resources.VS;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(155, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 27);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(725, 293);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(41, 22);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.labelSocket);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.ptbMark);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelPlayer);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(1, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 198);
            this.panel1.TabIndex = 9;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(61, 82);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 13);
            this.labelStatus.TabIndex = 12;
            // 
            // labelSocket
            // 
            this.labelSocket.AutoSize = true;
            this.labelSocket.Location = new System.Drawing.Point(61, 57);
            this.labelSocket.Name = "labelSocket";
            this.labelSocket.Size = new System.Drawing.Size(0, 13);
            this.labelSocket.TabIndex = 12;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(61, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 13);
            this.labelName.TabIndex = 12;
            // 
            // ptbMark
            // 
            this.ptbMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbMark.Location = new System.Drawing.Point(61, 108);
            this.ptbMark.Name = "ptbMark";
            this.ptbMark.Size = new System.Drawing.Size(75, 75);
            this.ptbMark.TabIndex = 5;
            this.ptbMark.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status:";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.Location = new System.Drawing.Point(51, 0);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(60, 22);
            this.labelPlayer.TabIndex = 11;
            this.labelPlayer.Text = "Player";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mark:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Socket:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelStatusRival);
            this.panel2.Controls.Add(this.labelSocketRival);
            this.panel2.Controls.Add(this.labelNameRival);
            this.panel2.Controls.Add(this.ptbMarkRival);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.labelRival);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(177, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 198);
            this.panel2.TabIndex = 8;
            // 
            // labelStatusRival
            // 
            this.labelStatusRival.AutoSize = true;
            this.labelStatusRival.Location = new System.Drawing.Point(57, 82);
            this.labelStatusRival.Name = "labelStatusRival";
            this.labelStatusRival.Size = new System.Drawing.Size(0, 13);
            this.labelStatusRival.TabIndex = 12;
            // 
            // labelSocketRival
            // 
            this.labelSocketRival.AutoSize = true;
            this.labelSocketRival.Location = new System.Drawing.Point(57, 57);
            this.labelSocketRival.Name = "labelSocketRival";
            this.labelSocketRival.Size = new System.Drawing.Size(0, 13);
            this.labelSocketRival.TabIndex = 12;
            // 
            // labelNameRival
            // 
            this.labelNameRival.AutoSize = true;
            this.labelNameRival.Location = new System.Drawing.Point(57, 33);
            this.labelNameRival.Name = "labelNameRival";
            this.labelNameRival.Size = new System.Drawing.Size(0, 13);
            this.labelNameRival.TabIndex = 12;
            // 
            // ptbMarkRival
            // 
            this.ptbMarkRival.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbMarkRival.Location = new System.Drawing.Point(60, 108);
            this.ptbMarkRival.Name = "ptbMarkRival";
            this.ptbMarkRival.Size = new System.Drawing.Size(75, 75);
            this.ptbMarkRival.TabIndex = 5;
            this.ptbMarkRival.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Status:";
            // 
            // labelRival
            // 
            this.labelRival.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRival.AutoSize = true;
            this.labelRival.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRival.Location = new System.Drawing.Point(60, 2);
            this.labelRival.Name = "labelRival";
            this.labelRival.Size = new System.Drawing.Size(50, 22);
            this.labelRival.TabIndex = 10;
            this.labelRival.Text = "Rival";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mark:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Socket:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name:";
            // 
            // tbLog
            // 
            this.tbLog.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbLog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbLog.Location = new System.Drawing.Point(3, 3);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(398, 238);
            this.tbLog.TabIndex = 0;
            this.tbLog.TextChanged += new System.EventHandler(this.tbLog_TextChanged);
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.Controls.Add(this.lbPlayer);
            this.pnlPlayer.Location = new System.Drawing.Point(419, 37);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(134, 245);
            this.pnlPlayer.TabIndex = 1;
            // 
            // lbPlayer
            // 
            this.lbPlayer.FormattingEnabled = true;
            this.lbPlayer.Location = new System.Drawing.Point(4, 3);
            this.lbPlayer.MultiColumn = true;
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbPlayer.Size = new System.Drawing.Size(128, 238);
            this.lbPlayer.TabIndex = 0;
            this.lbPlayer.SelectedIndexChanged += new System.EventHandler(this.lbPlayer_SelectedIndexChanged);
            this.lbPlayer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbPlayer_KeyDown);
            // 
            // btnStartServer
            // 
            this.btnStartServer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStartServer.Location = new System.Drawing.Point(12, 284);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(128, 41);
            this.btnStartServer.TabIndex = 2;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = false;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(324, 284);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(92, 41);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(230, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 41);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbChat
            // 
            this.tbChat.Location = new System.Drawing.Point(423, 284);
            this.tbChat.Multiline = true;
            this.tbChat.Name = "tbChat";
            this.tbChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbChat.Size = new System.Drawing.Size(128, 41);
            this.tbChat.TabIndex = 7;
            this.tbChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbChat_KeyDown);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(146, 284);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(78, 41);
            this.btnDetails.TabIndex = 6;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 337);
            this.Controls.Add(this.pnlInformation);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbChat);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.pnlPlayer);
            this.Controls.Add(this.pnlLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GOMOKU SERVER";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.pnlLog.ResumeLayout(false);
            this.pnlLog.PerformLayout();
            this.pnlInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMark)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMarkRival)).EndInit();
            this.pnlPlayer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLog;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.ListBox lbPlayer;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbChat;
        private System.Windows.Forms.Label labelRival;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptbMarkRival;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbMark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelStatusRival;
        private System.Windows.Forms.Label labelSocketRival;
        private System.Windows.Forms.Label labelNameRival;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelSocket;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnDetails;
    }
}

