namespace DCSLibraryRepository
{
    partial class MainForm
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
            DetailsLabel = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // DetailsLabel
            // 
            DetailsLabel.Anchor = AnchorStyles.Top;
            DetailsLabel.Depth = 0;
            DetailsLabel.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            DetailsLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            DetailsLabel.Location = new Point(19, 100);
            DetailsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            DetailsLabel.Name = "DetailsLabel";
            DetailsLabel.Size = new Size(1149, 495);
            DetailsLabel.TabIndex = 0;
            DetailsLabel.Text = "The main page mofo";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 659);
            Controls.Add(DetailsLabel);
            Name = "MainForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DCS Library Repository";
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel DetailsLabel;
    }
}