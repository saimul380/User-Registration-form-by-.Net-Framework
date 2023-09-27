namespace User_Registration_form
{
    partial class userRegiForm
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
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.textBox_middleName = new System.Windows.Forms.TextBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.lb_firstName = new System.Windows.Forms.Label();
            this.lb_middleName = new System.Windows.Forms.Label();
            this.lb_lastName = new System.Windows.Forms.Label();
            this.button_Show = new System.Windows.Forms.Button();
            this.textBox_fullName = new System.Windows.Forms.TextBox();
            this.lb_fullName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(196, 29);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(134, 20);
            this.textBox_firstName.TabIndex = 0;
            // 
            // textBox_middleName
            // 
            this.textBox_middleName.Location = new System.Drawing.Point(196, 58);
            this.textBox_middleName.Name = "textBox_middleName";
            this.textBox_middleName.Size = new System.Drawing.Size(134, 20);
            this.textBox_middleName.TabIndex = 1;
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(196, 84);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(134, 20);
            this.textBox_lastName.TabIndex = 2;
            // 
            // lb_firstName
            // 
            this.lb_firstName.AutoSize = true;
            this.lb_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_firstName.Location = new System.Drawing.Point(86, 32);
            this.lb_firstName.Name = "lb_firstName";
            this.lb_firstName.Size = new System.Drawing.Size(67, 13);
            this.lb_firstName.TabIndex = 1;
            this.lb_firstName.Text = "First Name";
            // 
            // lb_middleName
            // 
            this.lb_middleName.AutoSize = true;
            this.lb_middleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_middleName.Location = new System.Drawing.Point(86, 58);
            this.lb_middleName.Name = "lb_middleName";
            this.lb_middleName.Size = new System.Drawing.Size(80, 13);
            this.lb_middleName.TabIndex = 1;
            this.lb_middleName.Text = "Middle Name";
            // 
            // lb_lastName
            // 
            this.lb_lastName.AutoSize = true;
            this.lb_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lastName.Location = new System.Drawing.Point(86, 87);
            this.lb_lastName.Name = "lb_lastName";
            this.lb_lastName.Size = new System.Drawing.Size(67, 13);
            this.lb_lastName.TabIndex = 1;
            this.lb_lastName.Text = "Last Name";
            // 
            // button_Show
            // 
            this.button_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Show.Location = new System.Drawing.Point(270, 110);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(60, 23);
            this.button_Show.TabIndex = 3;
            this.button_Show.Text = "Show";
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // textBox_fullName
            // 
            this.textBox_fullName.Location = new System.Drawing.Point(196, 164);
            this.textBox_fullName.Name = "textBox_fullName";
            this.textBox_fullName.Size = new System.Drawing.Size(134, 20);
            this.textBox_fullName.TabIndex = 4;
            // 
            // lb_fullName
            // 
            this.lb_fullName.AutoSize = true;
            this.lb_fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullName.Location = new System.Drawing.Point(86, 167);
            this.lb_fullName.Name = "lb_fullName";
            this.lb_fullName.Size = new System.Drawing.Size(63, 13);
            this.lb_fullName.TabIndex = 1;
            this.lb_fullName.Text = "Full Name";
            // 
            // userRegiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 293);
            this.Controls.Add(this.button_Show);
            this.Controls.Add(this.lb_lastName);
            this.Controls.Add(this.lb_middleName);
            this.Controls.Add(this.lb_fullName);
            this.Controls.Add(this.lb_firstName);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.textBox_fullName);
            this.Controls.Add(this.textBox_middleName);
            this.Controls.Add(this.textBox_firstName);
            this.Name = "userRegiForm";
            this.Text = "User Registation Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.TextBox textBox_middleName;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.Label lb_firstName;
        private System.Windows.Forms.Label lb_middleName;
        private System.Windows.Forms.Label lb_lastName;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.TextBox textBox_fullName;
        private System.Windows.Forms.Label lb_fullName;
    }
}

