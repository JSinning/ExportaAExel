namespace exportInforms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.body = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.userId,
            this.title,
            this.body});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 299);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(835, 187);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 41;
            // 
            // userId
            // 
            this.userId.Text = "nombre";
            this.userId.Width = 116;
            // 
            // title
            // 
            this.title.Text = "Titulo";
            this.title.Width = 306;
            // 
            // body
            // 
            this.body.Text = "descripcion";
            this.body.Width = 364;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(48, 255);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(301, 20);
            this.TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(379, 255);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.Location = new System.Drawing.Point(653, 254);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(102, 23);
            this.BtnReport.TabIndex = 3;
            this.BtnReport.Text = "Generar Reporte";
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 498);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader userId;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader body;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnReport;
    }
}

