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
            button3 = new Button();
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
            // button3
            // 
            button3.Location = new Point(46, 223);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
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
            Controls.Add(button3);
            Controls.Add(btnSelectCaliVendors);
            Controls.Add(btnSelectAllVendors);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelectAllVendors;
        private Button btnSelectCaliVendors;
        private Button button3;
        private ListView lstResults;
    }
}
