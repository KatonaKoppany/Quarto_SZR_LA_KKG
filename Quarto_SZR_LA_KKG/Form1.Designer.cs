
namespace Quarto_SZR_LA_KKG
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jatekos1_TBOX = new System.Windows.Forms.TextBox();
            this.jatekos2_TBOX = new System.Windows.Forms.TextBox();
            this.start_BTN = new System.Windows.Forms.Button();
            this.keplista = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Játékos 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Játékos 2:";
            // 
            // jatekos1_TBOX
            // 
            this.jatekos1_TBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jatekos1_TBOX.Location = new System.Drawing.Point(105, 33);
            this.jatekos1_TBOX.Name = "jatekos1_TBOX";
            this.jatekos1_TBOX.Size = new System.Drawing.Size(100, 24);
            this.jatekos1_TBOX.TabIndex = 2;
            // 
            // jatekos2_TBOX
            // 
            this.jatekos2_TBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jatekos2_TBOX.Location = new System.Drawing.Point(105, 93);
            this.jatekos2_TBOX.Name = "jatekos2_TBOX";
            this.jatekos2_TBOX.Size = new System.Drawing.Size(100, 24);
            this.jatekos2_TBOX.TabIndex = 3;
            // 
            // start_BTN
            // 
            this.start_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_BTN.Location = new System.Drawing.Point(90, 163);
            this.start_BTN.Name = "start_BTN";
            this.start_BTN.Size = new System.Drawing.Size(100, 35);
            this.start_BTN.TabIndex = 4;
            this.start_BTN.Text = "Start";
            this.start_BTN.UseVisualStyleBackColor = true;
            this.start_BTN.Click += new System.EventHandler(this.start_BTN_Click);
            // 
            // keplista
            // 
            this.keplista.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("keplista.ImageStream")));
            this.keplista.TransparentColor = System.Drawing.Color.Transparent;
            this.keplista.Images.SetKeyName(0, "01.png");
            this.keplista.Images.SetKeyName(1, "02.png");
            this.keplista.Images.SetKeyName(2, "03.png");
            this.keplista.Images.SetKeyName(3, "04.png");
            this.keplista.Images.SetKeyName(4, "05.png");
            this.keplista.Images.SetKeyName(5, "06.png");
            this.keplista.Images.SetKeyName(6, "07.png");
            this.keplista.Images.SetKeyName(7, "08.png");
            this.keplista.Images.SetKeyName(8, "11.png");
            this.keplista.Images.SetKeyName(9, "12.png");
            this.keplista.Images.SetKeyName(10, "13.png");
            this.keplista.Images.SetKeyName(11, "14.png");
            this.keplista.Images.SetKeyName(12, "15.png");
            this.keplista.Images.SetKeyName(13, "16.png");
            this.keplista.Images.SetKeyName(14, "17.png");
            this.keplista.Images.SetKeyName(15, "18.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.start_BTN);
            this.Controls.Add(this.jatekos2_TBOX);
            this.Controls.Add(this.jatekos1_TBOX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Quarto!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jatekos1_TBOX;
        private System.Windows.Forms.TextBox jatekos2_TBOX;
        private System.Windows.Forms.Button start_BTN;
        private System.Windows.Forms.ImageList keplista;
    }
}

