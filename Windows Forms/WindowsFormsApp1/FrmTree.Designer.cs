namespace WindowsFormsApp1
{
    partial class FrmTree
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nó5");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nó3", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Nó0", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Nó1");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Nó2");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Nó4");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnChecados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(22, 22);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "Nó5";
            treeNode7.Text = "Nó5";
            treeNode8.Name = "Nó3";
            treeNode8.Text = "Nó3";
            treeNode9.Name = "Nó0";
            treeNode9.Text = "Nó0";
            treeNode10.Name = "Nó1";
            treeNode10.Text = "Nó1";
            treeNode11.Name = "Nó2";
            treeNode11.Text = "Nó2";
            treeNode12.Name = "Nó4";
            treeNode12.Text = "Nó4";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(740, 401);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnChecados
            // 
            this.btnChecados.Location = new System.Drawing.Point(33, 442);
            this.btnChecados.Name = "btnChecados";
            this.btnChecados.Size = new System.Drawing.Size(75, 23);
            this.btnChecados.TabIndex = 1;
            this.btnChecados.Text = "Checados";
            this.btnChecados.UseVisualStyleBackColor = true;
            this.btnChecados.Click += new System.EventHandler(this.btnChecados_Click);
            // 
            // FrmTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 479);
            this.Controls.Add(this.btnChecados);
            this.Controls.Add(this.treeView1);
            this.Name = "FrmTree";
            this.Text = "FrmTree";
            this.Load += new System.EventHandler(this.FrmTree_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnChecados;
    }
}