
namespace personal_acountant
{
    partial class Resetpassword
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
            this.txtresetpass = new Krypton.Toolkit.KryptonTextBox();
            this.txtresetpassver = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // txtresetpass
            // 
            this.txtresetpass.Location = new System.Drawing.Point(307, 70);
            this.txtresetpass.Name = "txtresetpass";
            this.txtresetpass.Size = new System.Drawing.Size(186, 37);
            this.txtresetpass.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtresetpass.StateActive.Border.Rounding = 15F;
            this.txtresetpass.TabIndex = 0;
            // 
            // txtresetpassver
            // 
            this.txtresetpassver.Location = new System.Drawing.Point(307, 183);
            this.txtresetpassver.Name = "txtresetpassver";
            this.txtresetpassver.Size = new System.Drawing.Size(186, 37);
            this.txtresetpassver.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtresetpassver.StateActive.Border.Rounding = 15F;
            this.txtresetpassver.TabIndex = 1;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.CornerRoundingRadius = 15F;
            this.kryptonButton1.Location = new System.Drawing.Point(296, 291);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(186, 50);
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 15F;
            this.kryptonButton1.TabIndex = 2;
            this.kryptonButton1.Values.Text = "Reset";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(72, 79);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(155, 28);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "New Password";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(72, 192);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(187, 28);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Confirm Password";
            // 
            // Resetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.txtresetpassver);
            this.Controls.Add(this.txtresetpass);
            this.Name = "Resetpassword";
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
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtresetpass;
        private Krypton.Toolkit.KryptonTextBox txtresetpassver;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}