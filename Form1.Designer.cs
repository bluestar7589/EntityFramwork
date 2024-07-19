namespace EntityFramework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectAllVendors = new Button();
            btnSelectCaliVendors = new Button();
            btnSelectCondition = new Button();
            lstResults = new ListView();
            SuspendLayout();
            // 
            // btnSelectAllVendors
            // 
            btnSelectAllVendors.Location = new Point(46, 57);
            btnSelectAllVendors.Name = "btnSelectAllVendors";
            btnSelectAllVendors.Size = new Size(184, 23);
            btnSelectAllVendors.TabIndex = 0;
            btnSelectAllVendors.Text = "Select * From Vendors";
            btnSelectAllVendors.UseVisualStyleBackColor = true;
            btnSelectAllVendors.Click += btnSelectAllVendors_Click;
            // 
            // btnSelectCaliVendors
            // 
            btnSelectCaliVendors.Location = new Point(46, 132);
            btnSelectCaliVendors.Name = "btnSelectCaliVendors";
            btnSelectCaliVendors.Size = new Size(290, 23);
            btnSelectCaliVendors.TabIndex = 1;
            btnSelectCaliVendors.Text = "Select * From Vendor Where VendorState= 'CA'";
            btnSelectCaliVendors.UseVisualStyleBackColor = true;
            btnSelectCaliVendors.Click += btnSelectCaliVendors_Click;
            // 
            // btnSelectCondition
            // 
            btnSelectCondition.Location = new Point(46, 223);
            btnSelectCondition.Name = "btnSelectCondition";
            btnSelectCondition.Size = new Size(340, 23);
            btnSelectCondition.TabIndex = 2;
            btnSelectCondition.Text = "Select VendorName, VendorCity, VendorState From Vendors";
            btnSelectCondition.UseVisualStyleBackColor = true;
            btnSelectCondition.Click += btnSelectCondition_Click;
            // 
            // lstResults
            // 
            lstResults.Location = new Point(404, 40);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(423, 249);
            lstResults.TabIndex = 3;
            lstResults.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 425);
            Controls.Add(lstResults);
            Controls.Add(btnSelectCondition);
            Controls.Add(btnSelectCaliVendors);
            Controls.Add(btnSelectAllVendors);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelectAllVendors;
        private Button btnSelectCaliVendors;
        private Button btnSelectCondition;
        private ListView lstResults;
    }
}
