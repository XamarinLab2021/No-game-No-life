
namespace NoGameNoLifeMenu
{
    partial class empty2
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
            this.Playbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Playbutton
            // 
            this.Playbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.Playbutton.FlatAppearance.BorderSize = 0;
            this.Playbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Playbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Playbutton.ForeColor = System.Drawing.Color.White;
            this.Playbutton.Location = new System.Drawing.Point(189, 162);
            this.Playbutton.Name = "Playbutton";
            this.Playbutton.Size = new System.Drawing.Size(247, 68);
            this.Playbutton.TabIndex = 1;
            this.Playbutton.Text = "Play";
            this.Playbutton.UseVisualStyleBackColor = false;
            this.Playbutton.Click += new System.EventHandler(this.Playbutton_Click);
            // 
            // empty2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.Playbutton);
            this.Name = "empty2";
            this.Size = new System.Drawing.Size(625, 392);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Playbutton;
    }
}
