﻿namespace GOMOKU_SERVER_APP
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
            this.tbLog = new System.Windows.Forms.TextBox();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.lbPlayer = new System.Windows.Forms.ListBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbChat = new System.Windows.Forms.TextBox();
            this.pnlLog.SuspendLayout();
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
            this.lbPlayer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbPlayer_KeyDown);
            // 
            // btnStartServer
            // 
            this.btnStartServer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStartServer.Location = new System.Drawing.Point(12, 284);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(128, 30);
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
            this.btnSend.Location = new System.Drawing.Point(338, 284);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 30);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(422, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbChat
            // 
            this.tbChat.Location = new System.Drawing.Point(147, 285);
            this.tbChat.Multiline = true;
            this.tbChat.Name = "tbChat";
            this.tbChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbChat.Size = new System.Drawing.Size(185, 30);
            this.tbChat.TabIndex = 7;
            this.tbChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbChat_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 320);
            this.Controls.Add(this.tbChat);
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
    }
}

