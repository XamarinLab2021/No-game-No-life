
namespace NoGameNoLifeMenu.Minigames
{
    partial class RockPaperScissors
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_scissors = new System.Windows.Forms.Button();
            this.button_paper = new System.Windows.Forms.Button();
            this.button_rock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(216, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 60);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(216, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 60);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_scissors
            // 
            this.button_scissors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.button_scissors.BackgroundImage = global::NoGameNoLifeMenu.Properties.Resources.noto_v1_scissors;
            this.button_scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_scissors.FlatAppearance.BorderSize = 0;
            this.button_scissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_scissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_scissors.ForeColor = System.Drawing.Color.White;
            this.button_scissors.Location = new System.Drawing.Point(424, 319);
            this.button_scissors.Name = "button_scissors";
            this.button_scissors.Size = new System.Drawing.Size(172, 60);
            this.button_scissors.TabIndex = 2;
            this.button_scissors.UseVisualStyleBackColor = false;
            this.button_scissors.Click += new System.EventHandler(this.button_scissors_Click);
            // 
            // button_paper
            // 
            this.button_paper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.button_paper.BackgroundImage = global::NoGameNoLifeMenu.Properties.Resources.noto_roll_of_paper;
            this.button_paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_paper.FlatAppearance.BorderSize = 0;
            this.button_paper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_paper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_paper.ForeColor = System.Drawing.Color.White;
            this.button_paper.Location = new System.Drawing.Point(216, 319);
            this.button_paper.Name = "button_paper";
            this.button_paper.Size = new System.Drawing.Size(172, 60);
            this.button_paper.TabIndex = 1;
            this.button_paper.UseVisualStyleBackColor = false;
            this.button_paper.Click += new System.EventHandler(this.button_paper_Click);
            // 
            // button_rock
            // 
            this.button_rock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.button_rock.BackgroundImage = global::NoGameNoLifeMenu.Properties.Resources.noto_rock;
            this.button_rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_rock.FlatAppearance.BorderSize = 0;
            this.button_rock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_rock.ForeColor = System.Drawing.Color.White;
            this.button_rock.Location = new System.Drawing.Point(8, 319);
            this.button_rock.Name = "button_rock";
            this.button_rock.Size = new System.Drawing.Size(172, 60);
            this.button_rock.TabIndex = 0;
            this.button_rock.UseVisualStyleBackColor = false;
            this.button_rock.Click += new System.EventHandler(this.button_rock_Click);
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_scissors);
            this.Controls.Add(this.button_paper);
            this.Controls.Add(this.button_rock);
            this.Name = "RockPaperScissors";
            this.Size = new System.Drawing.Size(604, 391);
            this.Load += new System.EventHandler(this.RockPaperScissors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_rock;
        private System.Windows.Forms.Button button_paper;
        private System.Windows.Forms.Button button_scissors;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}
