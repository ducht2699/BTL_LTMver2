namespace Gamecaro
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
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbChat = new System.Windows.Forms.TextBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.tbLogChat = new System.Windows.Forms.TextBox();
            this.btnSendChat = new System.Windows.Forms.Button();
            this.btnLAN = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pctbMark = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChessBoard.Location = new System.Drawing.Point(221, 35);
            this.pnlChessBoard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(526, 462);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbChat);
            this.panel3.Controls.Add(this.tbLog);
            this.panel3.Controls.Add(this.tbLogChat);
            this.panel3.Controls.Add(this.btnSendChat);
            this.panel3.Controls.Add(this.btnLAN);
            this.panel3.Controls.Add(this.txbIP);
            this.panel3.Controls.Add(this.pctbMark);
            this.panel3.Controls.Add(this.txbPlayerName);
            this.panel3.Location = new System.Drawing.Point(7, 35);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 462);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log";
            // 
            // tbChat
            // 
            this.tbChat.Location = new System.Drawing.Point(2, 439);
            this.tbChat.Name = "tbChat";
            this.tbChat.Size = new System.Drawing.Size(140, 20);
            this.tbChat.TabIndex = 2;
            this.tbChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbChat_KeyDown);
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(3, 88);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(205, 123);
            this.tbLog.TabIndex = 1;
            // 
            // tbLogChat
            // 
            this.tbLogChat.Location = new System.Drawing.Point(2, 229);
            this.tbLogChat.Multiline = true;
            this.tbLogChat.Name = "tbLogChat";
            this.tbLogChat.ReadOnly = true;
            this.tbLogChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLogChat.Size = new System.Drawing.Size(205, 205);
            this.tbLogChat.TabIndex = 1;
            // 
            // btnSendChat
            // 
            this.btnSendChat.Location = new System.Drawing.Point(147, 439);
            this.btnSendChat.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendChat.Name = "btnSendChat";
            this.btnSendChat.Size = new System.Drawing.Size(60, 21);
            this.btnSendChat.TabIndex = 0;
            this.btnSendChat.Text = "SEND";
            this.btnSendChat.UseVisualStyleBackColor = true;
            this.btnSendChat.Click += new System.EventHandler(this.btnSendChat_Click);
            // 
            // btnLAN
            // 
            this.btnLAN.Location = new System.Drawing.Point(74, 50);
            this.btnLAN.Margin = new System.Windows.Forms.Padding(2);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(134, 20);
            this.btnLAN.TabIndex = 0;
            this.btnLAN.Text = "CONNECT";
            this.btnLAN.UseVisualStyleBackColor = true;
            this.btnLAN.Click += new System.EventHandler(this.btnLAN_Click);
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(114, 26);
            this.txbIP.Margin = new System.Windows.Forms.Padding(2);
            this.txbIP.Name = "txbIP";
            this.txbIP.ReadOnly = true;
            this.txbIP.ShortcutsEnabled = false;
            this.txbIP.Size = new System.Drawing.Size(94, 20);
            this.txbIP.TabIndex = 0;
            this.txbIP.Text = "127.0.0.1";
            this.txbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Location = new System.Drawing.Point(114, 2);
            this.txbPlayerName.Margin = new System.Windows.Forms.Padding(2);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.Size = new System.Drawing.Size(94, 20);
            this.txbPlayerName.TabIndex = 0;
            this.txbPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPlayerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPlayerName_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // pctbMark
            // 
            this.pctbMark.BackColor = System.Drawing.SystemColors.Control;
            this.pctbMark.Image = global::Gamecaro.Properties.Resources.super_mario_flat_design_wallpaper_by_ivanomatt147_d9qvku9_fullview1;
            this.pctbMark.Location = new System.Drawing.Point(2, 2);
            this.pctbMark.Margin = new System.Windows.Forms.Padding(2);
            this.pctbMark.Name = "pctbMark";
            this.pctbMark.Size = new System.Drawing.Size(68, 68);
            this.pctbMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbMark.TabIndex = 0;
            this.pctbMark.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 515);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.PictureBox pctbMark;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.TextBox tbChat;
        private System.Windows.Forms.TextBox tbLogChat;
        private System.Windows.Forms.Button btnSendChat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

