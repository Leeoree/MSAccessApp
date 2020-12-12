
namespace MSAccessApp.Forms
{
    partial class AllRequests
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
            this.TableView = new System.Windows.Forms.ListView();
            this.Doctors2019 = new System.Windows.Forms.Button();
            this.Doctors1 = new System.Windows.Forms.Button();
            this.Pacients5 = new System.Windows.Forms.Button();
            this.AppointmentsDate = new System.Windows.Forms.Button();
            this.DateForAppointments = new System.Windows.Forms.TextBox();
            this.Birthday = new System.Windows.Forms.Button();
            this.BirthdayDate = new System.Windows.Forms.TextBox();
            this.PacientDiag = new System.Windows.Forms.Button();
            this.Diag = new System.Windows.Forms.TextBox();
            this.AddProc = new System.Windows.Forms.Button();
            this.DeleteProc = new System.Windows.Forms.Button();
            this.ChangeProc = new System.Windows.Forms.Button();
            this.Nazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TableView
            // 
            this.TableView.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableView.HideSelection = false;
            this.TableView.Location = new System.Drawing.Point(0, 0);
            this.TableView.Name = "TableView";
            this.TableView.Size = new System.Drawing.Size(800, 234);
            this.TableView.TabIndex = 0;
            this.TableView.UseCompatibleStateImageBehavior = false;
            // 
            // Doctors2019
            // 
            this.Doctors2019.Location = new System.Drawing.Point(13, 241);
            this.Doctors2019.Name = "Doctors2019";
            this.Doctors2019.Size = new System.Drawing.Size(299, 23);
            this.Doctors2019.TabIndex = 1;
            this.Doctors2019.Text = "Врачи с приёмами в 2019";
            this.Doctors2019.UseVisualStyleBackColor = true;
            this.Doctors2019.Click += new System.EventHandler(this.Doctors2019_Click);
            // 
            // Doctors1
            // 
            this.Doctors1.Location = new System.Drawing.Point(13, 299);
            this.Doctors1.Name = "Doctors1";
            this.Doctors1.Size = new System.Drawing.Size(299, 23);
            this.Doctors1.TabIndex = 2;
            this.Doctors1.Text = "Поставшие диагноз №1 врачи";
            this.Doctors1.UseVisualStyleBackColor = true;
            this.Doctors1.Click += new System.EventHandler(this.Doctors1_Click);
            // 
            // Pacients5
            // 
            this.Pacients5.Location = new System.Drawing.Point(13, 270);
            this.Pacients5.Name = "Pacients5";
            this.Pacients5.Size = new System.Drawing.Size(299, 23);
            this.Pacients5.TabIndex = 3;
            this.Pacients5.Text = "Количесвто пациентов со страховым полисом  >7000 0000";
            this.Pacients5.UseVisualStyleBackColor = true;
            this.Pacients5.Click += new System.EventHandler(this.Pacients70000000_Click);
            // 
            // AppointmentsDate
            // 
            this.AppointmentsDate.Location = new System.Drawing.Point(13, 328);
            this.AppointmentsDate.Name = "AppointmentsDate";
            this.AppointmentsDate.Size = new System.Drawing.Size(299, 23);
            this.AppointmentsDate.TabIndex = 4;
            this.AppointmentsDate.Text = "Приёмы на выбранной дате";
            this.AppointmentsDate.UseVisualStyleBackColor = true;
            this.AppointmentsDate.Click += new System.EventHandler(this.AppointmentsDate_Click);
            // 
            // DateForAppointments
            // 
            this.DateForAppointments.Location = new System.Drawing.Point(318, 328);
            this.DateForAppointments.Name = "DateForAppointments";
            this.DateForAppointments.Size = new System.Drawing.Size(231, 20);
            this.DateForAppointments.TabIndex = 5;
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(13, 358);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(299, 23);
            this.Birthday.TabIndex = 6;
            this.Birthday.Text = "Пациенты с ДР позже даты";
            this.Birthday.UseVisualStyleBackColor = true;
            this.Birthday.Click += new System.EventHandler(this.Birthday_Click);
            // 
            // BirthdayDate
            // 
            this.BirthdayDate.Location = new System.Drawing.Point(318, 358);
            this.BirthdayDate.Name = "BirthdayDate";
            this.BirthdayDate.Size = new System.Drawing.Size(231, 20);
            this.BirthdayDate.TabIndex = 7;
            // 
            // PacientDiag
            // 
            this.PacientDiag.Location = new System.Drawing.Point(13, 388);
            this.PacientDiag.Name = "PacientDiag";
            this.PacientDiag.Size = new System.Drawing.Size(299, 23);
            this.PacientDiag.TabIndex = 8;
            this.PacientDiag.Text = "Пациенты с определённым диаогнозом";
            this.PacientDiag.UseVisualStyleBackColor = true;
            this.PacientDiag.Click += new System.EventHandler(this.PacientDiag_Click);
            // 
            // Diag
            // 
            this.Diag.Location = new System.Drawing.Point(318, 388);
            this.Diag.Name = "Diag";
            this.Diag.Size = new System.Drawing.Size(231, 20);
            this.Diag.TabIndex = 9;
            // 
            // AddProc
            // 
            this.AddProc.Location = new System.Drawing.Point(13, 418);
            this.AddProc.Name = "AddProc";
            this.AddProc.Size = new System.Drawing.Size(299, 23);
            this.AddProc.TabIndex = 10;
            this.AddProc.Text = "Добавить процедуру";
            this.AddProc.UseVisualStyleBackColor = true;
            this.AddProc.Click += new System.EventHandler(this.AddProc_Click);
            // 
            // DeleteProc
            // 
            this.DeleteProc.Location = new System.Drawing.Point(13, 448);
            this.DeleteProc.Name = "DeleteProc";
            this.DeleteProc.Size = new System.Drawing.Size(299, 23);
            this.DeleteProc.TabIndex = 11;
            this.DeleteProc.Text = "Удалить процедуру";
            this.DeleteProc.UseVisualStyleBackColor = true;
            this.DeleteProc.Click += new System.EventHandler(this.DeleteProc_Click);
            // 
            // ChangeProc
            // 
            this.ChangeProc.Location = new System.Drawing.Point(13, 478);
            this.ChangeProc.Name = "ChangeProc";
            this.ChangeProc.Size = new System.Drawing.Size(299, 23);
            this.ChangeProc.TabIndex = 12;
            this.ChangeProc.Text = "Изменить процедуру";
            this.ChangeProc.UseVisualStyleBackColor = true;
            this.ChangeProc.Click += new System.EventHandler(this.ChangeProc_Click);
            // 
            // Nazad
            // 
            this.Nazad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Nazad.Location = new System.Drawing.Point(0, 532);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(800, 40);
            this.Nazad.TabIndex = 13;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // AllRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.ChangeProc);
            this.Controls.Add(this.DeleteProc);
            this.Controls.Add(this.AddProc);
            this.Controls.Add(this.Diag);
            this.Controls.Add(this.PacientDiag);
            this.Controls.Add(this.BirthdayDate);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.DateForAppointments);
            this.Controls.Add(this.AppointmentsDate);
            this.Controls.Add(this.Pacients5);
            this.Controls.Add(this.Doctors1);
            this.Controls.Add(this.Doctors2019);
            this.Controls.Add(this.TableView);
            this.Name = "AllRequests";
            this.Text = "AllRequests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView TableView;
        private System.Windows.Forms.Button Doctors2019;
        private System.Windows.Forms.Button Doctors1;
        private System.Windows.Forms.Button Pacients5;
        private System.Windows.Forms.Button AppointmentsDate;
        private System.Windows.Forms.TextBox DateForAppointments;
        private System.Windows.Forms.Button Birthday;
        private System.Windows.Forms.TextBox BirthdayDate;
        private System.Windows.Forms.Button PacientDiag;
        private System.Windows.Forms.TextBox Diag;
        private System.Windows.Forms.Button AddProc;
        private System.Windows.Forms.Button DeleteProc;
        private System.Windows.Forms.Button ChangeProc;
        private System.Windows.Forms.Button Nazad;
    }
}