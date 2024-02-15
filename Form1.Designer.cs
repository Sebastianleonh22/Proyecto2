
namespace Proyecto2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaAtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaAdelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BotonIr = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navegarToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1313, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navegarToolStripMenuItem
            // 
            this.navegarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciioToolStripMenuItem,
            this.haciaAtrasToolStripMenuItem,
            this.haciaAdelanteToolStripMenuItem});
            this.navegarToolStripMenuItem.Name = "navegarToolStripMenuItem";
            this.navegarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.navegarToolStripMenuItem.Text = "Navegar";
            // 
            // iniciioToolStripMenuItem
            // 
            this.iniciioToolStripMenuItem.Name = "iniciioToolStripMenuItem";
            this.iniciioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iniciioToolStripMenuItem.Text = "Inicio";
            this.iniciioToolStripMenuItem.Click += new System.EventHandler(this.iniciioToolStripMenuItem_Click);
            // 
            // haciaAtrasToolStripMenuItem
            // 
            this.haciaAtrasToolStripMenuItem.Name = "haciaAtrasToolStripMenuItem";
            this.haciaAtrasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.haciaAtrasToolStripMenuItem.Text = "Hacia atras";
            this.haciaAtrasToolStripMenuItem.Click += new System.EventHandler(this.haciaAtrasToolStripMenuItem_Click);
            // 
            // haciaAdelanteToolStripMenuItem
            // 
            this.haciaAdelanteToolStripMenuItem.Name = "haciaAdelanteToolStripMenuItem";
            this.haciaAdelanteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.haciaAdelanteToolStripMenuItem.Text = "Hacia adelante";
            this.haciaAdelanteToolStripMenuItem.Click += new System.EventHandler(this.haciaAdelanteToolStripMenuItem_Click);
            // 
            // BotonIr
            // 
            this.BotonIr.Location = new System.Drawing.Point(1041, 40);
            this.BotonIr.Name = "BotonIr";
            this.BotonIr.Size = new System.Drawing.Size(84, 22);
            this.BotonIr.TabIndex = 2;
            this.BotonIr.Text = "Ir";
            this.BotonIr.UseVisualStyleBackColor = true;
            this.BotonIr.Click += new System.EventHandler(this.BotonIr_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(276, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(759, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(12, 98);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1289, 560);
            this.webView21.Source = new System.Uri("https://www.microsoft.com.", System.UriKind.Absolute);
            this.webView21.TabIndex = 4;
            this.webView21.ZoomFactor = 1D;
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.historialToolStripMenuItem.Text = "Historial";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1313, 783);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BotonIr);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Navegador Web";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haciaAtrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haciaAdelanteToolStripMenuItem;
        private System.Windows.Forms.Button BotonIr;
        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

