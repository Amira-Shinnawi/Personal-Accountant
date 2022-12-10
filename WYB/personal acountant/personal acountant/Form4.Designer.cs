
namespace personal_acountant
{
    partial class sendcode
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
            this.txtemail = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.txtvercode = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(286, 52);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(229, 37);
            this.txtemail.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtemail.StateActive.Border.Rounding = 15F;
            this.txtemail.TabIndex = 0;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.CornerRoundingRadius = 15F;
            this.kryptonButton1.Location = new System.Drawing.Point(327, 133);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(153, 43);
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 15F;
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.Text = "Send";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // txtvercode
            // 
            this.txtvercode.Location = new System.Drawing.Point(286, 213);
            this.txtvercode.Name = "txtvercode";
            this.txtvercode.Size = new System.Drawing.Size(229, 37);
            this.txtvercode.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtvercode.StateActive.Border.Rounding = 15F;
            this.txtvercode.TabIndex = 2;
            this.txtvercode.TextChanged += new System.EventHandler(this.txtvercode_TextChanged);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.CornerRoundingRadius = 15F;
            this.kryptonButton2.Location = new System.Drawing.Point(327, 279);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(153, 43);
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.Rounding = 15F;
            this.kryptonButton2.TabIndex = 3;
            this.kryptonButton2.Values.Text = "Verify Code";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(143, 61);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(67, 28);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "Email";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(143, 222);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(64, 28);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel2.TabIndex = 5;
            this.kryptonLabel2.Values.Text = "Code";
            // 
            // sendcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.txtvercode);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.txtemail);
            this.Name = "sendcode";
            this.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.StateActive.Back.Color2 = System.Drawing.Color.White;
            this.StateActive.Border.Color1 = System.Drawing.Color.White;
            this.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 15;
            this.StateActive.Header.Back.Color1 = System.Drawing.Color.White;
            this.StateActive.Header.Back.Color2 = System.Drawing.Color.White;
            this.StateActive.Header.Border.Color1 = System.Drawing.Color.White;
            this.StateActive.Header.Border.Color2 = System.Drawing.Color.White;
            this.StateActive.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Header.Border.Rounding = 15;
            this.Text = "Sendcode";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtemail;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonTextBox txtvercode;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}