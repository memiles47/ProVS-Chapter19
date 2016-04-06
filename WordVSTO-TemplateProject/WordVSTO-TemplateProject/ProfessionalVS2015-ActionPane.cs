using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;

namespace WordVSTO_TemplateProject
{
    partial class ProfessionalVS2015_ActionPane : UserControl
    {
        public ProfessionalVS2015_ActionPane()
        {
            InitializeComponent();
        }

        private void btn_getName_Click(object sender, EventArgs e)
        {
            var myIdent = System.Security.Principal.WindowsIdentity.GetCurrent();
            Globals.ThisDocument.txt_empName.Text = myIdent.Name;
        }
    }
}
