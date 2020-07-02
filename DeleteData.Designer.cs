namespace Lec10
{
    partial class DeleteData
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
            this.deleteId = new System.Windows.Forms.TextBox();
            this.deleteSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteId
            // 
            this.deleteId.Location = new System.Drawing.Point(126, 84);
            this.deleteId.Name = "deleteId";
            this.deleteId.Size = new System.Drawing.Size(100, 20);
            this.deleteId.TabIndex = 19;
            // 
            // deleteSubmit
            // 
            this.deleteSubmit.Location = new System.Drawing.Point(105, 210);
            this.deleteSubmit.Name = "deleteSubmit";
            this.deleteSubmit.Size = new System.Drawing.Size(75, 23);
            this.deleteSubmit.TabIndex = 18;
            this.deleteSubmit.Text = "Submit";
            this.deleteSubmit.UseVisualStyleBackColor = true;
            this.deleteSubmit.Click += new System.EventHandler(this.deleteSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "DELETE ITEMS";
            // 
            // DeleteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.deleteId);
            this.Controls.Add(this.deleteSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteData";
            this.Text = "DeleteData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox deleteId;
        private System.Windows.Forms.Button deleteSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}