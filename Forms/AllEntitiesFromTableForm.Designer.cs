﻿namespace MSAccessApp.Forms
{
    partial class AllEntitiesFromTableForm
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
            button1.Click -= _handleStadiumsGetOnClick;
            button2.Click -= _handleTeamsGetOnClick;
            button3.Click -= _handleSportmansGetOnClick;
            button4.Click -= _handleResultsGetOnClick;
            button5.Click += _handleSportTypeGetOnClick;

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
            this.button1.Location = new System.Drawing.Point(70, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Стадионы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += _handleStadiumsGetOnClick;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 51);
            this.button2.TabIndex = 0;
            this.button2.Text = "Команды";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += _handleTeamsGetOnClick;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(467, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 51);
            this.button3.TabIndex = 0;
            this.button3.Text = "Спортсмены";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += _handleSportmansGetOnClick;

            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(677, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 50);
            this.button4.TabIndex = 0;
            this.button4.Text = "Результаты";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += _handleResultsGetOnClick;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(843, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 50);
            this.button5.TabIndex = 0;
            this.button5.Text = "Виды спорта";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += _handleSportTypeGetOnClick;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вывод строк таблиц";
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
