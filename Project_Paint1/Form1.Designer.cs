﻿namespace Project_Paint1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.butClean = new System.Windows.Forms.Button();
            this.butChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(13, 13);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(607, 425);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // butClean
            // 
            this.butClean.Location = new System.Drawing.Point(653, 23);
            this.butClean.Name = "butClean";
            this.butClean.Size = new System.Drawing.Size(118, 56);
            this.butClean.TabIndex = 1;
            this.butClean.Text = "Clean";
            this.butClean.UseVisualStyleBackColor = true;
            // 
            // butChange
            // 
            this.butChange.Location = new System.Drawing.Point(653, 85);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(118, 56);
            this.butChange.TabIndex = 2;
            this.butChange.Text = "Change color";
            this.butChange.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butChange);
            this.Controls.Add(this.butClean);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button butClean;
        private System.Windows.Forms.Button butChange;
    }
}

