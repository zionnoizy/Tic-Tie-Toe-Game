﻿namespace TTToe
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
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(138, 99);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(251, 233);
            this.A1.TabIndex = 0;
            this.A1.Text = "A1";
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button1_Click);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(451, 99);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(251, 233);
            this.A2.TabIndex = 1;
            this.A2.Text = "A2";
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button2_Click);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(768, 99);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(251, 233);
            this.A3.TabIndex = 2;
            this.A3.Text = "A3";
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button3_Click);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(138, 398);
            this.B1.Name = "B1";
            this.B1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.B1.Size = new System.Drawing.Size(251, 233);
            this.B1.TabIndex = 3;
            this.B1.Text = "B1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button4_Click);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(451, 398);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(251, 233);
            this.B2.TabIndex = 4;
            this.B2.Text = "B2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button5_Click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(768, 398);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(251, 233);
            this.B3.TabIndex = 5;
            this.B3.Text = "B3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button6_Click);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(138, 667);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(251, 233);
            this.C1.TabIndex = 6;
            this.C1.Text = "C1";
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button7_Click);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(451, 667);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(251, 233);
            this.C2.TabIndex = 7;
            this.C2.Text = "C2";
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button8_Click);
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(768, 667);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(251, 233);
            this.C3.TabIndex = 8;
            this.C3.Text = "C3";
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(377, 58);
            this.button10.TabIndex = 9;
            this.button10.Text = "Restart";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(438, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 69);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome to TicTacToe!!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 1051);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TTT by non-teacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B1;
    }
}

