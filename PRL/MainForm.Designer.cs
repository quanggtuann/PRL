namespace PRL
{
    partial class MainForm
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
            btn_show = new Button();
            pn_show = new Panel();
            btntesst = new Button();
            SuspendLayout();
            // 
            // btn_show
            // 
            btn_show.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show.Location = new Point(25, 35);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(147, 82);
            btn_show.TabIndex = 0;
            btn_show.Text = "Show";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += button1_Click;
            // 
            // pn_show
            // 
            pn_show.Location = new Point(198, 12);
            pn_show.Name = "pn_show";
            pn_show.Size = new Size(635, 502);
            pn_show.TabIndex = 1;
            // 
            // btntesst
            // 
            btntesst.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btntesst.Location = new Point(25, 170);
            btntesst.Name = "btntesst";
            btntesst.Size = new Size(147, 82);
            btntesst.TabIndex = 2;
            btntesst.Text = "Show test";
            btntesst.UseVisualStyleBackColor = true;
            btntesst.Click += btntesst_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 516);
            Controls.Add(btntesst);
            Controls.Add(pn_show);
            Controls.Add(btn_show);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_show;
        private Panel pn_show;
        private Button btntesst;
    }
}
