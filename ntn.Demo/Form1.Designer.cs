
namespace ntn.Demo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetText = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.txtValue = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGetText
            // 
            this.btnGetText.Location = new System.Drawing.Point(25, 227);
            this.btnGetText.Name = "btnGetText";
            this.btnGetText.Size = new System.Drawing.Size(712, 43);
            this.btnGetText.TabIndex = 0;
            this.btnGetText.Text = "Lấy nội dung cho Request";
            this.btnGetText.UseVisualStyleBackColor = true;
            this.btnGetText.Click += new System.EventHandler(this.btnGetText_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(25, 12);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(712, 196);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = "";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(25, 289);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(712, 183);
            this.txtValue.TabIndex = 3;
            this.txtValue.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnGetText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetText;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.RichTextBox txtValue;
    }
}

