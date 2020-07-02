namespace Lec10
{
    partial class UpdateData
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
            this.updateName = new System.Windows.Forms.TextBox();
            this.updateId = new System.Windows.Forms.TextBox();
            this.updateSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateName
            // 
            this.updateName.Location = new System.Drawing.Point(126, 121);
            this.updateName.Name = "updateName";
            this.updateName.Size = new System.Drawing.Size(100, 20);
            this.updateName.TabIndex = 14;
            // 
            // updateId
            // 
            this.updateId.Location = new System.Drawing.Point(126, 84);
            this.updateId.Name = "updateId";
            this.updateId.Size = new System.Drawing.Size(100, 20);
            this.updateId.TabIndex = 13;
            // 
            // updateSubmit
            // 
            this.updateSubmit.Location = new System.Drawing.Point(105, 210);
            this.updateSubmit.Name = "updateSubmit";
            this.updateSubmit.Size = new System.Drawing.Size(75, 23);
            this.updateSubmit.TabIndex = 12;
            this.updateSubmit.Text = "Submit";
            this.updateSubmit.UseVisualStyleBackColor = true;
            this.updateSubmit.Click += new System.EventHandler(this.updateSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "UPDATE ITEM NAME";
            // 
            // UpdateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.updateName);
            this.Controls.Add(this.updateId);
            this.Controls.Add(this.updateSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateData";
            this.Text = "UpdateData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox updateName;
        private System.Windows.Forms.TextBox updateId;
        private System.Windows.Forms.Button updateSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}