namespace QLHS.Views
{
    partial class frm_Student
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
            this.dgv_Student = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Student
            // 
            this.dgv_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student.Location = new System.Drawing.Point(12, 22);
            this.dgv_Student.Name = "dgv_Student";
            this.dgv_Student.Size = new System.Drawing.Size(731, 405);
            this.dgv_Student.TabIndex = 0;
            // 
            // frm_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 453);
            this.Controls.Add(this.dgv_Student);
            this.Name = "frm_Student";
            this.Text = "frm_student";
            this.Load += new System.EventHandler(this.frm_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Student;
    }
}