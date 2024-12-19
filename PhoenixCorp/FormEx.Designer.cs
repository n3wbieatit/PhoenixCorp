namespace PhoenixCorp
{
    partial class FormEx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEx));
            this.rtbEx = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbEx
            // 
            this.rtbEx.Location = new System.Drawing.Point(13, 13);
            this.rtbEx.Name = "rtbEx";
            this.rtbEx.Size = new System.Drawing.Size(481, 325);
            this.rtbEx.TabIndex = 0;
            this.rtbEx.Text = "";
            // 
            // FormEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 350);
            this.Controls.Add(this.rtbEx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEx";
            this.Text = "FormEx";
            this.ResumeLayout(false);

        }

        #endregion

        // Поле для вывода результата задач
        private System.Windows.Forms.RichTextBox rtbEx;
    }
}