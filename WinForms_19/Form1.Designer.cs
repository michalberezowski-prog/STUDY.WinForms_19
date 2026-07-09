
namespace WinForms_19
{
    partial class Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxName = new System.Windows.Forms.ListBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowSelection = new System.Windows.Forms.Button();
            this.lblShowSelection = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxName
            // 
            this.lbxName.FormattingEnabled = true;
            this.lbxName.ItemHeight = 20;
            this.lbxName.Location = new System.Drawing.Point(22, 12);
            this.lbxName.Name = "lbxName";
            this.lbxName.Size = new System.Drawing.Size(331, 404);
            this.lbxName.TabIndex = 0;
            this.lbxName.SelectedIndexChanged += new System.EventHandler(this.lbxName_SelectedIndexChanged);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(410, 42);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(193, 26);
            this.tbxName.TabIndex = 1;
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(410, 124);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(193, 47);
            this.btnAddName.TabIndex = 2;
            this.btnAddName.Text = "Add Name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(410, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(528, 380);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowSelection
            // 
            this.btnShowSelection.Location = new System.Drawing.Point(410, 199);
            this.btnShowSelection.Name = "btnShowSelection";
            this.btnShowSelection.Size = new System.Drawing.Size(193, 45);
            this.btnShowSelection.TabIndex = 5;
            this.btnShowSelection.Text = "Show Selection";
            this.btnShowSelection.UseVisualStyleBackColor = true;
            this.btnShowSelection.Click += new System.EventHandler(this.btnShowSelection_Click);
            // 
            // lblShowSelection
            // 
            this.lblShowSelection.AutoSize = true;
            this.lblShowSelection.Location = new System.Drawing.Point(629, 209);
            this.lblShowSelection.Name = "lblShowSelection";
            this.lblShowSelection.Size = new System.Drawing.Size(51, 20);
            this.lblShowSelection.TabIndex = 6;
            this.lblShowSelection.Text = "label1";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(629, 242);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(73, 20);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.Text = "lblOutput";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(633, 380);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 35);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblShowSelection);
            this.Controls.Add(this.btnShowSelection);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lbxName);
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowSelection;
        private System.Windows.Forms.Label lblShowSelection;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnEdit;
    }
}

