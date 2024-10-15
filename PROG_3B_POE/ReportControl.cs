using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_3B_POE
{
    public partial class ReportControl : UserControl
    {
        public ReportControl()
        {
            InitializeComponent();
        }

        // Declaring the variables
        #region
        private string _File;
        private string _Location;
        private string _Description;
        private Image _ReportImage;
        private string _Category;

        //---------------------------Getters and Setters---------------------------//

        [Category("Custom Props")]
        public string File
        {
            get { return _File; }
            set { _File = value; lbFile.Text = value; }
        }
        
        [Category("Custom Props")]
        public string Location
        {
            get { return _Location; }
            set { _Location = value; lbLocation.Text = value; }
        }
        [Category("Custom Props")]
        public string Description
        {
            get { return _Description; }
            set { _Description = value; lbDescription.Text = value; }
        }
        [Category("Custom Props")]
        public Image ReportImage
        {
            get { return _ReportImage; }
            set { _ReportImage = value; reportImage.Image = value; }
        }
       
        [Category("Custom Props")]
        public string EventCategory
        {
            get { return _Category; }
            set { _Category = value; lbCategory.Text = value; }
        }
        #endregion
    }
}
