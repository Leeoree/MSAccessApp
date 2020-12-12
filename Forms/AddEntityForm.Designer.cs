namespace MSAccessApp.Forms
{
    partial class AddEntityForm
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
            foreach (var radioButton in _tablesRadioButtons)
            {
                radioButton.CheckedChanged -= HandleTablesCheckedChanged;
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
            this.SuspendLayout();
            // 
            // Nazad
            // 
            this.Nazad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Nazad.Location = new System.Drawing.Point(0, 447);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(634, 40);
            this.Nazad.TabIndex = 1;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // AddEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(634, 487);
            this.Controls.Add(this.Nazad);
            this.Name = "AddEntityForm";
            this.Text = "Добавить запись в таблицу";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Nazad;
    }
}