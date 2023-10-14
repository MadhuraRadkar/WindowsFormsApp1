namespace WindowsFormsApp1
{
    partial class Form2
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
            this.lblEmp_id = new System.Windows.Forms.Label();
            this.lblEmp_name = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblBasic_salary = new System.Windows.Forms.Label();
            this.lblHRA = new System.Windows.Forms.Label();
            this.lblDA = new System.Windows.Forms.Label();
            this.lblTA = new System.Windows.Forms.Label();
            this.lblPF = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.txtEmp_id = new System.Windows.Forms.TextBox();
            this.txtEmp_name = new System.Windows.Forms.TextBox();
            this.txtBasic_salary = new System.Windows.Forms.TextBox();
            this.txtHRA = new System.Windows.Forms.TextBox();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.txtPF = new System.Windows.Forms.TextBox();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.combDepartment = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmp_id
            // 
            this.lblEmp_id.AutoSize = true;
            this.lblEmp_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp_id.Location = new System.Drawing.Point(116, 32);
            this.lblEmp_id.Name = "lblEmp_id";
            this.lblEmp_id.Size = new System.Drawing.Size(65, 20);
            this.lblEmp_id.TabIndex = 0;
            this.lblEmp_id.Text = "Emp_id";
            // 
            // lblEmp_name
            // 
            this.lblEmp_name.AutoSize = true;
            this.lblEmp_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp_name.Location = new System.Drawing.Point(116, 81);
            this.lblEmp_name.Name = "lblEmp_name";
            this.lblEmp_name.Size = new System.Drawing.Size(93, 20);
            this.lblEmp_name.TabIndex = 1;
            this.lblEmp_name.Text = "Emp_name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(116, 133);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(97, 20);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "Department";
            // 
            // lblBasic_salary
            // 
            this.lblBasic_salary.AutoSize = true;
            this.lblBasic_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasic_salary.Location = new System.Drawing.Point(116, 184);
            this.lblBasic_salary.Name = "lblBasic_salary";
            this.lblBasic_salary.Size = new System.Drawing.Size(106, 20);
            this.lblBasic_salary.TabIndex = 3;
            this.lblBasic_salary.Text = "Basic_salary";
            // 
            // lblHRA
            // 
            this.lblHRA.AutoSize = true;
            this.lblHRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRA.Location = new System.Drawing.Point(116, 228);
            this.lblHRA.Name = "lblHRA";
            this.lblHRA.Size = new System.Drawing.Size(45, 20);
            this.lblHRA.TabIndex = 4;
            this.lblHRA.Text = "HRA";
            // 
            // lblDA
            // 
            this.lblDA.AutoSize = true;
            this.lblDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDA.Location = new System.Drawing.Point(116, 277);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(33, 20);
            this.lblDA.TabIndex = 5;
            this.lblDA.Text = "DA";
            // 
            // lblTA
            // 
            this.lblTA.AutoSize = true;
            this.lblTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTA.Location = new System.Drawing.Point(116, 329);
            this.lblTA.Name = "lblTA";
            this.lblTA.Size = new System.Drawing.Size(30, 20);
            this.lblTA.TabIndex = 6;
            this.lblTA.Text = "TA";
            // 
            // lblPF
            // 
            this.lblPF.AutoSize = true;
            this.lblPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPF.Location = new System.Drawing.Point(116, 380);
            this.lblPF.Name = "lblPF";
            this.lblPF.Size = new System.Drawing.Size(30, 20);
            this.lblPF.TabIndex = 7;
            this.lblPF.Text = "PF";
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGross.Location = new System.Drawing.Point(116, 429);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(55, 20);
            this.lblGross.TabIndex = 8;
            this.lblGross.Text = "Gross";
            // 
            // txtEmp_id
            // 
            this.txtEmp_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmp_id.Location = new System.Drawing.Point(261, 23);
            this.txtEmp_id.Name = "txtEmp_id";
            this.txtEmp_id.Size = new System.Drawing.Size(157, 27);
            this.txtEmp_id.TabIndex = 9;
            // 
            // txtEmp_name
            // 
            this.txtEmp_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmp_name.Location = new System.Drawing.Point(261, 75);
            this.txtEmp_name.Name = "txtEmp_name";
            this.txtEmp_name.Size = new System.Drawing.Size(157, 27);
            this.txtEmp_name.TabIndex = 10;
            // 
            // txtBasic_salary
            // 
            this.txtBasic_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasic_salary.Location = new System.Drawing.Point(261, 177);
            this.txtBasic_salary.Name = "txtBasic_salary";
            this.txtBasic_salary.Size = new System.Drawing.Size(157, 27);
            this.txtBasic_salary.TabIndex = 11;
            // 
            // txtHRA
            // 
            this.txtHRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHRA.Location = new System.Drawing.Point(261, 225);
            this.txtHRA.Name = "txtHRA";
            this.txtHRA.ReadOnly = true;
            this.txtHRA.Size = new System.Drawing.Size(157, 27);
            this.txtHRA.TabIndex = 12;
            // 
            // txtDA
            // 
            this.txtDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDA.Location = new System.Drawing.Point(261, 271);
            this.txtDA.Name = "txtDA";
            this.txtDA.ReadOnly = true;
            this.txtDA.Size = new System.Drawing.Size(157, 27);
            this.txtDA.TabIndex = 13;
            // 
            // txtTA
            // 
            this.txtTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTA.Location = new System.Drawing.Point(261, 323);
            this.txtTA.Name = "txtTA";
            this.txtTA.ReadOnly = true;
            this.txtTA.Size = new System.Drawing.Size(157, 27);
            this.txtTA.TabIndex = 14;
            // 
            // txtPF
            // 
            this.txtPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPF.Location = new System.Drawing.Point(261, 374);
            this.txtPF.Name = "txtPF";
            this.txtPF.ReadOnly = true;
            this.txtPF.Size = new System.Drawing.Size(157, 27);
            this.txtPF.TabIndex = 15;
            // 
            // txtGross
            // 
            this.txtGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGross.Location = new System.Drawing.Point(261, 423);
            this.txtGross.Name = "txtGross";
            this.txtGross.ReadOnly = true;
            this.txtGross.Size = new System.Drawing.Size(157, 27);
            this.txtGross.TabIndex = 16;
            // 
            // combDepartment
            // 
            this.combDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combDepartment.FormattingEnabled = true;
            this.combDepartment.Location = new System.Drawing.Point(261, 125);
            this.combDepartment.Name = "combDepartment";
            this.combDepartment.Size = new System.Drawing.Size(157, 28);
            this.combDepartment.TabIndex = 17;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Black;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Transparent;
            this.btnCalculate.Location = new System.Drawing.Point(473, 514);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 39);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.Location = new System.Drawing.Point(624, 514);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(129, 39);
            this.btnDisplay.TabIndex = 19;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(621, 125);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(64, 20);
            this.lblmsg.TabIndex = 21;
            this.lblmsg.Text = "lblmsg";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 598);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.combDepartment);
            this.Controls.Add(this.txtGross);
            this.Controls.Add(this.txtPF);
            this.Controls.Add(this.txtTA);
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.txtHRA);
            this.Controls.Add(this.txtBasic_salary);
            this.Controls.Add(this.txtEmp_name);
            this.Controls.Add(this.txtEmp_id);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.lblPF);
            this.Controls.Add(this.lblTA);
            this.Controls.Add(this.lblDA);
            this.Controls.Add(this.lblHRA);
            this.Controls.Add(this.lblBasic_salary);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblEmp_name);
            this.Controls.Add(this.lblEmp_id);
            this.Name = "Form2";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmp_id;
        private System.Windows.Forms.Label lblEmp_name;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblBasic_salary;
        private System.Windows.Forms.Label lblHRA;
        private System.Windows.Forms.Label lblDA;
        private System.Windows.Forms.Label lblTA;
        private System.Windows.Forms.Label lblPF;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.TextBox txtEmp_id;
        private System.Windows.Forms.TextBox txtEmp_name;
        private System.Windows.Forms.TextBox txtBasic_salary;
        private System.Windows.Forms.TextBox txtHRA;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.TextBox txtTA;
        private System.Windows.Forms.TextBox txtPF;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.ComboBox combDepartment;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblmsg;
    }
}