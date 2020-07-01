namespace Lec10
{
    partial class DataGridView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getD = new System.Windows.Forms.Button();
            this.updateD = new System.Windows.Forms.Button();
            this.insertD = new System.Windows.Forms.Button();
            this.deleteD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(350, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // getD
            // 
            this.getD.Location = new System.Drawing.Point(397, 43);
            this.getD.Name = "getD";
            this.getD.Size = new System.Drawing.Size(80, 23);
            this.getD.TabIndex = 1;
            this.getD.Text = "Get Data";
            this.getD.UseVisualStyleBackColor = true;
            this.getD.Click += new System.EventHandler(this.getD_Click);
            // 
            // updateD
            // 
            this.updateD.Location = new System.Drawing.Point(397, 81);
            this.updateD.Name = "updateD";
            this.updateD.Size = new System.Drawing.Size(80, 23);
            this.updateD.TabIndex = 2;
            this.updateD.Text = "Update Data";
            this.updateD.UseVisualStyleBackColor = true;
            this.updateD.Click += new System.EventHandler(this.updateD_Click);
            // 
            // insertD
            // 
            this.insertD.Location = new System.Drawing.Point(397, 121);
            this.insertD.Name = "insertD";
            this.insertD.Size = new System.Drawing.Size(80, 23);
            this.insertD.TabIndex = 3;
            this.insertD.Text = "Insert Data";
            this.insertD.UseVisualStyleBackColor = true;
            this.insertD.Click += new System.EventHandler(this.insertD_Click);
            // 
            // deleteD
            // 
            this.deleteD.Location = new System.Drawing.Point(397, 161);
            this.deleteD.Name = "deleteD";
            this.deleteD.Size = new System.Drawing.Size(80, 23);
            this.deleteD.TabIndex = 4;
            this.deleteD.Text = "Delete Data";
            this.deleteD.UseVisualStyleBackColor = true;
            this.deleteD.Click += new System.EventHandler(this.deleteD_Click);
            // 
            // DataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 311);
            this.Controls.Add(this.deleteD);
            this.Controls.Add(this.insertD);
            this.Controls.Add(this.updateD);
            this.Controls.Add(this.getD);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataGridView";
            this.Text = "Data Grid View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button getD;
        private System.Windows.Forms.Button updateD;
        private System.Windows.Forms.Button insertD;
        private System.Windows.Forms.Button deleteD;
    }
}

