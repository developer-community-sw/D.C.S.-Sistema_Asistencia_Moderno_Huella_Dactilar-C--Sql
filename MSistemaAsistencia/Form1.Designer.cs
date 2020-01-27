namespace MSistemaAsistencia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_titu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.elDivider1 = new Klik.Windows.Forms.v1.EntryLib.ELDivider();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_imagen = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_usu = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.txt_pass = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.elDivider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_usu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnl_titu
            // 
            this.pnl_titu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_titu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titu.Location = new System.Drawing.Point(0, 0);
            this.pnl_titu.Name = "pnl_titu";
            this.pnl_titu.Size = new System.Drawing.Size(921, 30);
            this.pnl_titu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(118, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Developer";
            // 
            // elDivider1
            // 
            this.elDivider1.FadeStyle = Klik.Windows.Forms.v1.EntryLib.DividerFadeStyles.Center;
            this.elDivider1.LineColor = System.Drawing.Color.Gainsboro;
            this.elDivider1.Location = new System.Drawing.Point(39, 174);
            this.elDivider1.Name = "elDivider1";
            this.elDivider1.Size = new System.Drawing.Size(337, 29);
            this.elDivider1.TabIndex = 4;
            this.elDivider1.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MSistemaAsistencia.Properties.Resources.battery;
            this.pictureBox2.Location = new System.Drawing.Point(12, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MSistemaAsistencia.Properties.Resources.solo_el_logo_transparente_1;
            this.pictureBox1.Location = new System.Drawing.Point(138, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 117);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_imagen
            // 
            this.pnl_imagen.BackgroundImage = global::MSistemaAsistencia.Properties.Resources.huella_digital1;
            this.pnl_imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_imagen.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_imagen.Location = new System.Drawing.Point(450, 30);
            this.pnl_imagen.Name = "pnl_imagen";
            this.pnl_imagen.Size = new System.Drawing.Size(471, 571);
            this.pnl_imagen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(89, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hecho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(156, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "con Energia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(282, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Todo es Posible";
            // 
            // txt_usu
            // 
            this.txt_usu.CaptionStyle.CaptionSize = 0;
            this.txt_usu.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_usu.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_usu.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txt_usu.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White;
            this.txt_usu.CaptionStyle.TextStyle.Text = "elEntryBox1";
            this.txt_usu.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.txt_usu.EditBoxStyle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usu.EditBoxStyle.ForeColor = System.Drawing.Color.DimGray;
            this.txt_usu.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txt_usu.Location = new System.Drawing.Point(93, 301);
            this.txt_usu.Name = "txt_usu";
            this.txt_usu.Size = new System.Drawing.Size(309, 38);
            this.txt_usu.TabIndex = 9;
            this.txt_usu.ValidationStyle.PasswordChar = '\0';
            this.txt_usu.Value = "";
            // 
            // txt_pass
            // 
            this.txt_pass.CaptionStyle.CaptionSize = 0;
            this.txt_pass.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_pass.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_pass.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txt_pass.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White;
            this.txt_pass.CaptionStyle.TextStyle.Text = "elEntryBox1";
            this.txt_pass.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.txt_pass.EditBoxStyle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.EditBoxStyle.ForeColor = System.Drawing.Color.DimGray;
            this.txt_pass.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txt_pass.Location = new System.Drawing.Point(93, 405);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(309, 38);
            this.txt_pass.TabIndex = 10;
            this.txt_pass.ValidationStyle.PasswordChar = '\0';
            this.txt_pass.ValidationStyle.UseSystemPasswordChar = true;
            this.txt_pass.Value = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 601);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_usu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_imagen);
            this.Controls.Add(this.pnl_titu);
            this.Controls.Add(this.elDivider1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.elDivider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_usu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnl_imagen;
        private System.Windows.Forms.Panel pnl_titu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Klik.Windows.Forms.v1.EntryLib.ELDivider elDivider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_pass;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_usu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

