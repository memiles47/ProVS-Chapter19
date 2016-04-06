using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Word;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

namespace WordVSTO_TemplateProject
{
    public partial class ThisDocument
    {
        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {
            dd_department.PlaceholderText = "Select your department";
            dd_department.DropDownListEntries.Add("Finance", "Finance", 0);
            dd_department.DropDownListEntries.Add("HR", "HR", 1);
            dd_department.DropDownListEntries.Add("IT", "IT", 2);
            dd_department.DropDownListEntries.Add("Marketing", "Marketing", 3);
            dd_department.DropDownListEntries.Add("Operations", "Operations", 4);

            this.ActionsPane.Controls.Add(new ProfessionalVS2015_ActionPane());
        }

        private void ThisDocument_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisDocument_Startup);
            this.Shutdown += new System.EventHandler(ThisDocument_Shutdown);
        }

        #endregion
    }
}
