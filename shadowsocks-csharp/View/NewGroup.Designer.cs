namespace Shadowsocks.View
{
    partial class NewGroup
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNewGroupConfirm = new System.Windows.Forms.Button();
            this.btnNewGroupCancel = new System.Windows.Forms.Button();
            this.labelNewGroup = new System.Windows.Forms.Label();
            this.textBoxNewGroup = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnNewGroupConfirm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNewGroupCancel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(342, 55);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNewGroupConfirm
            // 
            this.btnNewGroupConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewGroupConfirm.Location = new System.Drawing.Point(48, 16);
            this.btnNewGroupConfirm.Name = "btnNewGroupConfirm";
            this.btnNewGroupConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnNewGroupConfirm.TabIndex = 0;
            this.btnNewGroupConfirm.Text = "OK";
            this.btnNewGroupConfirm.UseVisualStyleBackColor = true;
            this.btnNewGroupConfirm.Click += new System.EventHandler(this.BtnNewGroupConfirm_Click);
            // 
            // btnNewGroupCancel
            // 
            this.btnNewGroupCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewGroupCancel.Location = new System.Drawing.Point(219, 16);
            this.btnNewGroupCancel.Name = "btnNewGroupCancel";
            this.btnNewGroupCancel.Size = new System.Drawing.Size(75, 23);
            this.btnNewGroupCancel.TabIndex = 1;
            this.btnNewGroupCancel.Text = "Cancel";
            this.btnNewGroupCancel.UseVisualStyleBackColor = true;
            this.btnNewGroupCancel.Click += new System.EventHandler(this.BtnNewGroupCancel_Click);
            // 
            // labelNewGroup
            // 
            this.labelNewGroup.AutoSize = true;
            this.labelNewGroup.Location = new System.Drawing.Point(13, 29);
            this.labelNewGroup.Name = "labelNewGroup";
            this.labelNewGroup.Size = new System.Drawing.Size(35, 12);
            this.labelNewGroup.TabIndex = 1;
            this.labelNewGroup.Text = "Group";
            // 
            // textBoxNewGroup
            // 
            this.textBoxNewGroup.Location = new System.Drawing.Point(78, 26);
            this.textBoxNewGroup.Name = "textBoxNewGroup";
            this.textBoxNewGroup.Size = new System.Drawing.Size(254, 21);
            this.textBoxNewGroup.TabIndex = 2;
            // 
            // NewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 127);
            this.Controls.Add(this.textBoxNewGroup);
            this.Controls.Add(this.labelNewGroup);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asign to new group";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNewGroupConfirm;
        private System.Windows.Forms.Button btnNewGroupCancel;
        private System.Windows.Forms.Label labelNewGroup;
        private System.Windows.Forms.TextBox textBoxNewGroup;
    }
}