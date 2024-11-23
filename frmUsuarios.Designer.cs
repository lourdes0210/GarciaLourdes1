namespace GarciaLourdes1
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Actividades");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Invitado");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Administrador", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Usuario Regular", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Usuario Avanzado", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Usuarios", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeViewUsuarios = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeViewUsuarios
            // 
            this.treeViewUsuarios.Location = new System.Drawing.Point(29, 56);
            this.treeViewUsuarios.Name = "treeViewUsuarios";
            treeNode7.Name = "Actividades";
            treeNode7.Text = "Actividades";
            treeNode8.Name = "Invitado";
            treeNode8.Text = "Invitado";
            treeNode9.Name = "Administrador";
            treeNode9.Text = "Administrador";
            treeNode10.Name = "Usuario Regular";
            treeNode10.Text = "Usuario Regular";
            treeNode11.Name = "Usuario Avanzado";
            treeNode11.Text = "Usuario Avanzado";
            treeNode12.Name = "Usuarios";
            treeNode12.Text = "Usuarios";
            this.treeViewUsuarios.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode12});
            this.treeViewUsuarios.Size = new System.Drawing.Size(279, 172);
            this.treeViewUsuarios.TabIndex = 0;
            this.treeViewUsuarios.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewUsuarios_AfterSelect);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeViewUsuarios);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewUsuarios;
    }
}