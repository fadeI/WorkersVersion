namespace WorkersVersion
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
            this.components = new System.ComponentModel.Container();
            this.dalyWorkers = new System.Windows.Forms.TabControl();
            this.WokersUpdate = new System.Windows.Forms.TabPage();
            this.newPlace = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.firsname = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.firstName_text = new System.Windows.Forms.TextBox();
            this.LastName_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.salary_txt = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hireDate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dalyWorkers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dalyWorkers
            // 
            this.dalyWorkers.Controls.Add(this.WokersUpdate);
            this.dalyWorkers.Controls.Add(this.newPlace);
            this.dalyWorkers.Controls.Add(this.tabPage3);
            this.dalyWorkers.Controls.Add(this.tabPage1);
            this.dalyWorkers.Location = new System.Drawing.Point(1, 0);
            this.dalyWorkers.Name = "dalyWorkers";
            this.dalyWorkers.SelectedIndex = 0;
            this.dalyWorkers.Size = new System.Drawing.Size(579, 258);
            this.dalyWorkers.TabIndex = 0;
            // 
            // WokersUpdate
            // 
            this.WokersUpdate.Location = new System.Drawing.Point(4, 22);
            this.WokersUpdate.Name = "WokersUpdate";
            this.WokersUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.WokersUpdate.Size = new System.Drawing.Size(571, 232);
            this.WokersUpdate.TabIndex = 0;
            this.WokersUpdate.Text = "Workers";
            this.WokersUpdate.UseVisualStyleBackColor = true;
            // 
            // newPlace
            // 
            this.newPlace.Location = new System.Drawing.Point(4, 22);
            this.newPlace.Name = "newPlace";
            this.newPlace.Padding = new System.Windows.Forms.Padding(3);
            this.newPlace.Size = new System.Drawing.Size(571, 232);
            this.newPlace.TabIndex = 1;
            this.newPlace.Text = "Add Place";
            this.newPlace.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(571, 232);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add Contractor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.hireDate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.salary_txt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.LastName_text);
            this.tabPage1.Controls.Add(this.firstName_text);
            this.tabPage1.Controls.Add(this.LastName);
            this.tabPage1.Controls.Add(this.firsname);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(571, 232);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Add Worker";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // firsname
            // 
            this.firsname.AutoSize = true;
            this.firsname.Location = new System.Drawing.Point(7, 17);
            this.firsname.Name = "firsname";
            this.firsname.Size = new System.Drawing.Size(63, 13);
            this.firsname.TabIndex = 0;
            this.firsname.Text = "First Name :";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(6, 50);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(64, 13);
            this.LastName.TabIndex = 1;
            this.LastName.Text = "Last Name :";
            // 
            // firstName_text
            // 
            this.firstName_text.Location = new System.Drawing.Point(76, 14);
            this.firstName_text.Name = "firstName_text";
            this.firstName_text.Size = new System.Drawing.Size(100, 20);
            this.firstName_text.TabIndex = 2;
            // 
            // LastName_text
            // 
            this.LastName_text.Location = new System.Drawing.Point(76, 47);
            this.LastName_text.Name = "LastName_text";
            this.LastName_text.Size = new System.Drawing.Size(100, 20);
            this.LastName_text.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salary :";
            // 
            // salary_txt
            // 
            this.salary_txt.Location = new System.Drawing.Point(76, 80);
            this.salary_txt.Name = "salary_txt";
            this.salary_txt.Size = new System.Drawing.Size(100, 20);
            this.salary_txt.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hire Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // hireDate
            // 
            this.hireDate.Checked = false;
            this.hireDate.Location = new System.Drawing.Point(283, 17);
            this.hireDate.Name = "hireDate";
            this.hireDate.Size = new System.Drawing.Size(182, 20);
            this.hireDate.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 258);
            this.Controls.Add(this.dalyWorkers);
            this.Name = "Form1";
            this.Text = "WorkerUpdater";
            this.dalyWorkers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl dalyWorkers;
        private System.Windows.Forms.TabPage WokersUpdate;
        private System.Windows.Forms.TabPage newPlace;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox LastName_text;
        private System.Windows.Forms.TextBox firstName_text;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label firsname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salary_txt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker hireDate;
        private System.Windows.Forms.TextBox textBox1;
    }
}

