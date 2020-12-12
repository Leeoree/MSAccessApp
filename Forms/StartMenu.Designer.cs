using System;

namespace MSAccessApp.Forms
{
    partial class StartMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    AllEntitiesFromTableFormButton.Click -= HadnleOpenFormClick;
        //    AddEntityFormButton.Click -= HadnleOpenFormClick;

        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AllEntitiesFromTableFormButton = new System.Windows.Forms.Button();
            this.AddEntityFormButton = new System.Windows.Forms.Button();
            this.RemoveEntityFromTableFormButton = new System.Windows.Forms.Button();
            this.EditEntityFromTableFormButton = new System.Windows.Forms.Button();
            this.MSysObjectsFormsButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Requests = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllEntitiesFromTableFormButton
            // 
            this.AllEntitiesFromTableFormButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AllEntitiesFromTableFormButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllEntitiesFromTableFormButton.Location = new System.Drawing.Point(12, 38);
            this.AllEntitiesFromTableFormButton.Name = "AllEntitiesFromTableFormButton";
            this.AllEntitiesFromTableFormButton.Size = new System.Drawing.Size(200, 50);
            this.AllEntitiesFromTableFormButton.TabIndex = 0;
            this.AllEntitiesFromTableFormButton.Text = "Список записей в таблицах";
            this.AllEntitiesFromTableFormButton.UseVisualStyleBackColor = false;
            this.AllEntitiesFromTableFormButton.Click += new System.EventHandler(this.AllEntitiesFromTableFormButton_Click);
            // 
            // AddEntityFormButton
            // 
            this.AddEntityFormButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddEntityFormButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEntityFormButton.Location = new System.Drawing.Point(12, 94);
            this.AddEntityFormButton.Name = "AddEntityFormButton";
            this.AddEntityFormButton.Size = new System.Drawing.Size(200, 50);
            this.AddEntityFormButton.TabIndex = 1;
            this.AddEntityFormButton.Text = "Добавить запись в таблицу";
            this.AddEntityFormButton.UseVisualStyleBackColor = false;
            this.AddEntityFormButton.Click += new System.EventHandler(this.AddEntityFormButton_Click);
            // 
            // RemoveEntityFromTableFormButton
            // 
            this.RemoveEntityFromTableFormButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveEntityFromTableFormButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveEntityFromTableFormButton.Location = new System.Drawing.Point(12, 150);
            this.RemoveEntityFromTableFormButton.Name = "RemoveEntityFromTableFormButton";
            this.RemoveEntityFromTableFormButton.Size = new System.Drawing.Size(200, 50);
            this.RemoveEntityFromTableFormButton.TabIndex = 2;
            this.RemoveEntityFromTableFormButton.Text = "Удалить запись из таблицы";
            this.RemoveEntityFromTableFormButton.UseVisualStyleBackColor = false;
            this.RemoveEntityFromTableFormButton.Click += new System.EventHandler(this.RemoveEntityFromTableFormButton_Click);
            // 
            // EditEntityFromTableFormButton
            // 
            this.EditEntityFromTableFormButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EditEntityFromTableFormButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditEntityFromTableFormButton.Location = new System.Drawing.Point(12, 206);
            this.EditEntityFromTableFormButton.Name = "EditEntityFromTableFormButton";
            this.EditEntityFromTableFormButton.Size = new System.Drawing.Size(200, 50);
            this.EditEntityFromTableFormButton.TabIndex = 3;
            this.EditEntityFromTableFormButton.Text = "Изменить запись в таблице";
            this.EditEntityFromTableFormButton.UseVisualStyleBackColor = false;
            this.EditEntityFromTableFormButton.Click += new System.EventHandler(this.EditEntityFromTableFormButton_Click);
            // 
            // MSysObjectsFormsButton
            // 
            this.MSysObjectsFormsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MSysObjectsFormsButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MSysObjectsFormsButton.Location = new System.Drawing.Point(12, 262);
            this.MSysObjectsFormsButton.Name = "MSysObjectsFormsButton";
            this.MSysObjectsFormsButton.Size = new System.Drawing.Size(200, 50);
            this.MSysObjectsFormsButton.TabIndex = 4;
            this.MSysObjectsFormsButton.Text = "Вызов MSysObjects";
            this.MSysObjectsFormsButton.UseVisualStyleBackColor = false;
            this.MSysObjectsFormsButton.Click += new System.EventHandler(this.MSysObjectsFormsButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AccessibleDescription = "";
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(190, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 20);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // Requests
            // 
            this.Requests.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Requests.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Requests.Location = new System.Drawing.Point(13, 319);
            this.Requests.Name = "Requests";
            this.Requests.Size = new System.Drawing.Size(200, 50);
            this.Requests.TabIndex = 6;
            this.Requests.Text = "Вызов запросов";
            this.Requests.UseVisualStyleBackColor = false;
            this.Requests.Click += new System.EventHandler(this.Requests_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(226, 378);
            this.Controls.Add(this.Requests);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MSysObjectsFormsButton);
            this.Controls.Add(this.EditEntityFromTableFormButton);
            this.Controls.Add(this.RemoveEntityFromTableFormButton);
            this.Controls.Add(this.AddEntityFormButton);
            this.Controls.Add(this.AllEntitiesFromTableFormButton);
            this.Name = "StartMenu";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AllEntitiesFromTableFormButton;
        private System.Windows.Forms.Button AddEntityFormButton;
        private System.Windows.Forms.Button RemoveEntityFromTableFormButton;
        private System.Windows.Forms.Button EditEntityFromTableFormButton;
        private System.Windows.Forms.Button MSysObjectsFormsButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button Requests;
    }
}