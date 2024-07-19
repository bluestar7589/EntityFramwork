using EntityFramework.Data;
using EntityFramework.Models;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method to get all from vendors table from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectAllVendors_Click(object sender, EventArgs e)
        {
            using ApContext context = new ApContext();

            List<Vendor> lstVendorsMethod = new List<Vendor>();
            // LINQ - Languate Integrated Query - method sybtax
            lstVendorsMethod = context.Vendors.ToList();

            // LINQ query syntax
            List<Vendor> lstVendorsQuery = new List<Vendor>();
            lstVendorsQuery = (from v in context.Vendors select v).ToList();
        }

        private void btnSelectCaliVendors_Click(object sender, EventArgs e)
        {
            using ApContext context = new ApContext();
            List<Vendor> lstVendorMethod = context.Vendors.Where(v => v.VendorState == "CA")
                                                          .OrderBy(v => v.VendorName).ToList();

            List<Vendor> lstVendorSyntax = (from v in context.Vendors 
                                            where v.VendorState == "CA" 
                                            orderby v.VendorName 
                                            select v).ToList();
        }
    }
}
