
namespace NoGameNoLifeMenu
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
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelX = new System.Windows.Forms.Label();
            this.label_ = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.empty22 = new NoGameNoLifeMenu.empty2();
            this.tictactoe2 = new NoGameNoLifeMenu.tictactoe();
            this.empty21 = new NoGameNoLifeMenu.empty2();
            this.empty1 = new NoGameNoLifeMenu.empty();
            this.tictactoe1 = new NoGameNoLifeMenu.tictactoe();
            this.rockPaperScissors1 = new NoGameNoLifeMenu.Minigames.RockPaperScissors();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.LogoPanel.Controls.Add(this.panel3);
            this.LogoPanel.Controls.Add(this.labelX);
            this.LogoPanel.Controls.Add(this.label_);
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Controls.Add(this.label1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(950, 65);
            this.LogoPanel.TabIndex = 1;
            this.LogoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LogoPanel_Paint_1);
            this.LogoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogoPanel_MouseMove);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 58);
            this.panel3.TabIndex = 4;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelX.ForeColor = System.Drawing.Color.White;
            this.labelX.Location = new System.Drawing.Point(912, 12);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(27, 25);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "X";
            this.labelX.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_
            // 
            this.label_.AutoSize = true;
            this.label_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_.ForeColor = System.Drawing.Color.White;
            this.label_.Location = new System.Drawing.Point(883, 12);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(25, 25);
            this.label_.TabIndex = 4;
            this.label_.Text = "_";
            this.label_.Click += new System.EventHandler(this.label__Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NoGameNoLife";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 502);
            this.panel1.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(202, 60);
            this.button5.TabIndex = 7;
            this.button5.Text = "NEWGAME2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 60);
            this.button4.TabIndex = 6;
            this.button4.Text = "Rock Paper Scissors";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 60);
            this.SidePanel.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clicker";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tic-Tac-Toe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 60);
            this.button3.TabIndex = 5;
            this.button3.Text = "Shuffle Game";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // empty22
            // 
            this.empty22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.empty22.Location = new System.Drawing.Point(261, 121);
            this.empty22.Name = "empty22";
            this.empty22.Size = new System.Drawing.Size(625, 392);
            this.empty22.TabIndex = 7;
            this.empty22.Load += new System.EventHandler(this.empty22_Load);
            // 
            // tictactoe2
            // 
            this.tictactoe2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.tictactoe2.Location = new System.Drawing.Point(253, 113);
            this.tictactoe2.Name = "tictactoe2";
            this.tictactoe2.Size = new System.Drawing.Size(625, 391);
            this.tictactoe2.TabIndex = 6;
            // 
            // empty21
            // 
            this.empty21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.empty21.Location = new System.Drawing.Point(245, 105);
            this.empty21.Name = "empty21";
            this.empty21.Size = new System.Drawing.Size(625, 392);
            this.empty21.TabIndex = 5;
            this.empty21.Load += new System.EventHandler(this.empty21_Load);
            // 
            // empty1
            // 
            this.empty1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.empty1.Location = new System.Drawing.Point(251, 105);
            this.empty1.Name = "empty1";
            this.empty1.Size = new System.Drawing.Size(625, 392);
            this.empty1.TabIndex = 4;
            this.empty1.Load += new System.EventHandler(this.empty1_Load);
            // 
            // tictactoe1
            // 
            this.tictactoe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.tictactoe1.Location = new System.Drawing.Point(251, 105);
            this.tictactoe1.Name = "tictactoe1";
            this.tictactoe1.Size = new System.Drawing.Size(625, 391);
            this.tictactoe1.TabIndex = 3;
            // 
            // rockPaperScissors1
            // 
            this.rockPaperScissors1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.rockPaperScissors1.Location = new System.Drawing.Point(261, 93);
            this.rockPaperScissors1.Name = "rockPaperScissors1";
            this.rockPaperScissors1.Size = new System.Drawing.Size(604, 391);
            this.rockPaperScissors1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(950, 567);
            this.Controls.Add(this.rockPaperScissors1);
            this.Controls.Add(this.empty22);
            this.Controls.Add(this.tictactoe2);
            this.Controls.Add(this.empty21);
            this.Controls.Add(this.empty1);
            this.Controls.Add(this.tictactoe1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private tictactoe tictactoe1;
        private empty empty1;
        private System.Windows.Forms.Button button3;
        private empty2 empty21;
        private tictactoe tictactoe2;
        private empty2 empty22;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private Minigames.RockPaperScissors rockPaperScissors1;
    }
}

