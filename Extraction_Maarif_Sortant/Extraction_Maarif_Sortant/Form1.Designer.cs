namespace Extraction_Maarif_Sortant
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Btn_Select_all = new System.Windows.Forms.Button();
            this.Btn_Invert_Select = new System.Windows.Forms.Button();
            this.Btn_Unselect_all = new System.Windows.Forms.Button();
            this.Btn_Export_CSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(37, 22);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(270, 199);
            this.checkedListBox1.TabIndex = 0;
            // 
            // Btn_Select_all
            // 
            this.Btn_Select_all.Location = new System.Drawing.Point(37, 223);
            this.Btn_Select_all.Name = "Btn_Select_all";
            this.Btn_Select_all.Size = new System.Drawing.Size(86, 28);
            this.Btn_Select_all.TabIndex = 1;
            this.Btn_Select_all.Text = "Select All";
            this.Btn_Select_all.UseVisualStyleBackColor = true;
            this.Btn_Select_all.Click += new System.EventHandler(this.Btn_Select_all_Click);
            // 
            // Btn_Invert_Select
            // 
            this.Btn_Invert_Select.Location = new System.Drawing.Point(129, 223);
            this.Btn_Invert_Select.Name = "Btn_Invert_Select";
            this.Btn_Invert_Select.Size = new System.Drawing.Size(86, 28);
            this.Btn_Invert_Select.TabIndex = 2;
            this.Btn_Invert_Select.Text = "Invert Select";
            this.Btn_Invert_Select.UseVisualStyleBackColor = true;
            this.Btn_Invert_Select.Click += new System.EventHandler(this.Btn_Invert_Select_Click);
            // 
            // Btn_Unselect_all
            // 
            this.Btn_Unselect_all.Location = new System.Drawing.Point(221, 223);
            this.Btn_Unselect_all.Name = "Btn_Unselect_all";
            this.Btn_Unselect_all.Size = new System.Drawing.Size(86, 28);
            this.Btn_Unselect_all.TabIndex = 3;
            this.Btn_Unselect_all.Text = "Select None";
            this.Btn_Unselect_all.UseVisualStyleBackColor = true;
            this.Btn_Unselect_all.Click += new System.EventHandler(this.Btn_Unselect_all_Click);
            // 
            // Btn_Export_CSV
            // 
            this.Btn_Export_CSV.Location = new System.Drawing.Point(446, 48);
            this.Btn_Export_CSV.Name = "Btn_Export_CSV";
            this.Btn_Export_CSV.Size = new System.Drawing.Size(92, 27);
            this.Btn_Export_CSV.TabIndex = 4;
            this.Btn_Export_CSV.Text = "Export";
            this.Btn_Export_CSV.UseVisualStyleBackColor = true;
            this.Btn_Export_CSV.Click += new System.EventHandler(this.Btn_Export_CSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(398, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2019, 11, 4, 15, 24, 3, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Campagne";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 260);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Export_CSV);
            this.Controls.Add(this.Btn_Unselect_all);
            this.Controls.Add(this.Btn_Invert_Select);
            this.Controls.Add(this.Btn_Select_all);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Btn_Select_all;
        private System.Windows.Forms.Button Btn_Invert_Select;
        private System.Windows.Forms.Button Btn_Unselect_all;
        private System.Windows.Forms.Button Btn_Export_CSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}

