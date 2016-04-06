namespace WordVSTO_TemplateProject
{
    [System.ComponentModel.ToolboxItemAttribute(false)]
    partial class ProfessionalVS2015_ActionPane
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_getName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_getName
            // 
            this.btn_getName.Location = new System.Drawing.Point(70, 66);
            this.btn_getName.Name = "btn_getName";
            this.btn_getName.Size = new System.Drawing.Size(183, 38);
            this.btn_getName.TabIndex = 0;
            this.btn_getName.Text = "button1";
            this.btn_getName.UseVisualStyleBackColor = true;
            this.btn_getName.Click += new System.EventHandler(this.btn_getName_Click);
            // 
            // ProfessionalVS2015_ActionPane
            // 
            this.Controls.Add(this.btn_getName);
            this.Name = "ProfessionalVS2015_ActionPane";
            this.Size = new System.Drawing.Size(349, 170);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_getName;
    }
}
