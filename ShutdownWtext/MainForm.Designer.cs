﻿namespace ShutdownWtext
{
    partial class MainForm
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
            this.handleWindowEdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tituloJanelaEdt = new System.Windows.Forms.TextBox();
            this.textList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Obter Handle da janela";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // handleWindowEdt
            // 
            this.handleWindowEdt.Location = new System.Drawing.Point(205, 14);
            this.handleWindowEdt.Name = "handleWindowEdt";
            this.handleWindowEdt.Size = new System.Drawing.Size(139, 20);
            this.handleWindowEdt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Handle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Título da janela:";
            // 
            // tituloJanelaEdt
            // 
            this.tituloJanelaEdt.Location = new System.Drawing.Point(12, 55);
            this.tituloJanelaEdt.Name = "tituloJanelaEdt";
            this.tituloJanelaEdt.Size = new System.Drawing.Size(187, 20);
            this.tituloJanelaEdt.TabIndex = 4;
            // 
            // textList
            // 
            this.textList.FormattingEnabled = true;
            this.textList.Location = new System.Drawing.Point(12, 94);
            this.textList.Name = "textList";
            this.textList.Size = new System.Drawing.Size(332, 95);
            this.textList.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Textos encontrados:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Procurar textos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 494);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textList);
            this.Controls.Add(this.tituloJanelaEdt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.handleWindowEdt);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "ShutdownWtext";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox handleWindowEdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tituloJanelaEdt;
        private System.Windows.Forms.ListBox textList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

