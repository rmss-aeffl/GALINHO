﻿
namespace GALINHO
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Jogo 2 Jogadores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 78);
            this.button2.TabIndex = 1;
            this.button2.Text = "Jogo 1 Jogador";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Regras";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(404, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 31);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(404, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 31);
            this.button5.TabIndex = 4;
            this.button5.Text = "About";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 200);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}
