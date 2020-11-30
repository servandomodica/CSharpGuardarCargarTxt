namespace Proyecto125filedialog
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarElArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recuperarElArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cambiarFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cambiarColorDeFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.cambiarColorDeLetraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grabarElArchivoToolStripMenuItem,
            this.recuperarElArchivoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // grabarElArchivoToolStripMenuItem
            // 
            this.grabarElArchivoToolStripMenuItem.Name = "grabarElArchivoToolStripMenuItem";
            this.grabarElArchivoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.grabarElArchivoToolStripMenuItem.Text = "Grabar el archivo";
            this.grabarElArchivoToolStripMenuItem.Click += new System.EventHandler(this.grabarElArchivoToolStripMenuItem_Click);
            // 
            // recuperarElArchivoToolStripMenuItem
            // 
            this.recuperarElArchivoToolStripMenuItem.Name = "recuperarElArchivoToolStripMenuItem";
            this.recuperarElArchivoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.recuperarElArchivoToolStripMenuItem.Text = "Recuperar el archivo";
            this.recuperarElArchivoToolStripMenuItem.Click += new System.EventHandler(this.recuperarElArchivoToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Location = new System.Drawing.Point(0, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 424);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarFuenteToolStripMenuItem,
            this.cambiarColorDeFondoToolStripMenuItem,
            this.cambiarColorDeLetraToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(201, 92);
            // 
            // cambiarFuenteToolStripMenuItem
            // 
            this.cambiarFuenteToolStripMenuItem.Name = "cambiarFuenteToolStripMenuItem";
            this.cambiarFuenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarFuenteToolStripMenuItem.Text = "Cambiar fuente";
            this.cambiarFuenteToolStripMenuItem.Click += new System.EventHandler(this.cambiarFuenteToolStripMenuItem_Click);
            // 
            // cambiarColorDeFondoToolStripMenuItem
            // 
            this.cambiarColorDeFondoToolStripMenuItem.Name = "cambiarColorDeFondoToolStripMenuItem";
            this.cambiarColorDeFondoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cambiarColorDeFondoToolStripMenuItem.Text = "Cambiar color de fondo";
            this.cambiarColorDeFondoToolStripMenuItem.Click += new System.EventHandler(this.cambiarColorDeFondoToolStripMenuItem_Click);
            // 
            // cambiarColorDeLetraToolStripMenuItem
            // 
            this.cambiarColorDeLetraToolStripMenuItem.Name = "cambiarColorDeLetraToolStripMenuItem";
            this.cambiarColorDeLetraToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cambiarColorDeLetraToolStripMenuItem.Text = "Cambiar color de letra";
            this.cambiarColorDeLetraToolStripMenuItem.Click += new System.EventHandler(this.cambiarColorDeLetraToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grabarElArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recuperarElArchivoToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cambiarFuenteToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem cambiarColorDeFondoToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem cambiarColorDeLetraToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}

