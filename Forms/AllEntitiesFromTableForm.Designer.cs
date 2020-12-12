namespace MSAccessApp.Forms
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
            foreach(var handlerOnButton in _clickHandlerOnButton)
            {
                handlerOnButton.Key.Click -= handlerOnButton.Value;
            }

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
            this.Nazad = new System.Windows.Forms.Button();
            this.Doctors = new System.Windows.Forms.Button();
            this.TableView = new System.Windows.Forms.ListView();
            this.Pacients = new System.Windows.Forms.Button();
            this.Medical_establishments = new System.Windows.Forms.Button();
            this.Appointments = new System.Windows.Forms.Button();
            this.Diagnoses = new System.Windows.Forms.Button();
            this.Procedures = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nazad
            // 
            this.Nazad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Nazad.Location = new System.Drawing.Point(0, 600);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(1040, 40);
            this.Nazad.TabIndex = 0;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // Doctors
            // 
            this.Doctors.Location = new System.Drawing.Point(12, 549);
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(200, 45);
            this.Doctors.TabIndex = 1;
            this.Doctors.Text = "Врачи";
            this.Doctors.UseVisualStyleBackColor = true;
            this.Doctors.Click += new System.EventHandler(this.Doctors_Click);
            // 
            // TableView
            // 
            this.TableView.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableView.HideSelection = false;
            this.TableView.Location = new System.Drawing.Point(0, 0);
            this.TableView.Name = "TableView";
            this.TableView.Size = new System.Drawing.Size(1040, 543);
            this.TableView.TabIndex = 2;
            this.TableView.UseCompatibleStateImageBehavior = false;
            // 
            // Pacients
            // 
            this.Pacients.Location = new System.Drawing.Point(218, 549);
            this.Pacients.Name = "Pacients";
            this.Pacients.Size = new System.Drawing.Size(200, 45);
            this.Pacients.TabIndex = 3;
            this.Pacients.Text = "Пациенты";
            this.Pacients.UseVisualStyleBackColor = true;
            this.Pacients.Click += new System.EventHandler(this.Pacients_Click);
            // 
            // Medical_establishments
            // 
            this.Medical_establishments.Location = new System.Drawing.Point(424, 549);
            this.Medical_establishments.Name = "Medical_establishments";
            this.Medical_establishments.Size = new System.Drawing.Size(200, 45);
            this.Medical_establishments.TabIndex = 4;
            this.Medical_establishments.Text = "Лечебные учреждения";
            this.Medical_establishments.UseVisualStyleBackColor = true;
            this.Medical_establishments.Click += new System.EventHandler(this.Medical_establishments_Click);
            // 
            // Appointments
            // 
            this.Appointments.Location = new System.Drawing.Point(828, 549);
            this.Appointments.Name = "Appointments";
            this.Appointments.Size = new System.Drawing.Size(200, 45);
            this.Appointments.TabIndex = 5;
            this.Appointments.Text = "Приёмы";
            this.Appointments.UseVisualStyleBackColor = true;
            this.Appointments.Click += new System.EventHandler(this.Appointments_Click);
            // 
            // Diagnoses
            // 
            this.Diagnoses.Location = new System.Drawing.Point(630, 549);
            this.Diagnoses.Name = "Diagnoses";
            this.Diagnoses.Size = new System.Drawing.Size(86, 45);
            this.Diagnoses.TabIndex = 6;
            this.Diagnoses.Text = "Диагнозы";
            this.Diagnoses.UseVisualStyleBackColor = true;
            this.Diagnoses.Click += new System.EventHandler(this.Diagnoses_Click);
            // 
            // Procedures
            // 
            this.Procedures.Location = new System.Drawing.Point(722, 549);
            this.Procedures.Name = "Procedures";
            this.Procedures.Size = new System.Drawing.Size(100, 45);
            this.Procedures.TabIndex = 7;
            this.Procedures.Text = "Процедуры";
            this.Procedures.UseVisualStyleBackColor = true;
            this.Procedures.Click += new System.EventHandler(this.Procedures_Click);
            // 
            // AllEntitiesFromTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.Procedures);
            this.Controls.Add(this.Diagnoses);
            this.Controls.Add(this.Appointments);
            this.Controls.Add(this.Medical_establishments);
            this.Controls.Add(this.Pacients);
            this.Controls.Add(this.TableView);
            this.Controls.Add(this.Doctors);
            this.Controls.Add(this.Nazad);
            this.Name = "AllEntitiesFromTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вывод строк таблиц";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button Doctors;
        private System.Windows.Forms.ListView TableView;
        private System.Windows.Forms.Button Pacients;
        private System.Windows.Forms.Button Medical_establishments;
        private System.Windows.Forms.Button Appointments;
        private System.Windows.Forms.Button Diagnoses;
        private System.Windows.Forms.Button Procedures;
    }
}

