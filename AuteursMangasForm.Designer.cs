namespace AuteursMangas
{
    partial class AuteursMangasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuteursMangasForm));
            this.auteursMangasMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fichiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirUnePhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirUnePhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangasLabel = new System.Windows.Forms.Label();
            this.AuteursLabel = new System.Windows.Forms.Label();
            this.mangas = new System.Windows.Forms.Label();
            this.listeImagesLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.auteursTextBox = new System.Windows.Forms.TextBox();
            this.mangasListBox = new System.Windows.Forms.ListBox();
            this.resultatListBox = new System.Windows.Forms.ListBox();
            this.pairButton = new System.Windows.Forms.Button();
            this.impairButton = new System.Windows.Forms.Button();
            this.listeImagesListBox = new System.Windows.Forms.ListBox();
            this.auteursMangasOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.auteursMangasFontDialog = new System.Windows.Forms.FontDialog();
            this.selectButton = new System.Windows.Forms.Button();
            this.imagesPictureBox = new System.Windows.Forms.PictureBox();
            this.auteursMangasPictureBox = new System.Windows.Forms.PictureBox();
            this.auteursMangasMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auteursMangasPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // auteursMangasMenuStrip
            // 
            this.auteursMangasMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.auteursMangasMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichiersToolStripMenuItem,
            this.formatsToolStripMenuItem});
            this.auteursMangasMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.auteursMangasMenuStrip.Name = "auteursMangasMenuStrip";
            this.auteursMangasMenuStrip.Size = new System.Drawing.Size(994, 28);
            this.auteursMangasMenuStrip.TabIndex = 0;
            this.auteursMangasMenuStrip.Text = "menuStrip1";
            // 
            // fichiersToolStripMenuItem
            // 
            this.fichiersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirUnePhotosToolStripMenuItem});
            this.fichiersToolStripMenuItem.Name = "fichiersToolStripMenuItem";
            this.fichiersToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichiersToolStripMenuItem.Text = "&Fichier";
            // 
            // ouvrirUnePhotosToolStripMenuItem
            // 
            this.ouvrirUnePhotosToolStripMenuItem.Image = global::AuteursMangas.Properties.Resources._1000_F_468585023_oZ9bWqnreAxAuCa9hhnRx3eMcYLnXdPU;
            this.ouvrirUnePhotosToolStripMenuItem.Name = "ouvrirUnePhotosToolStripMenuItem";
            this.ouvrirUnePhotosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ouvrirUnePhotosToolStripMenuItem.Text = "&Ouvrir une photo...";
            this.ouvrirUnePhotosToolStripMenuItem.Click += new System.EventHandler(this.ouvrirUnePhotosToolStripMenuItem_Click);
            // 
            // formatsToolStripMenuItem
            // 
            this.formatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.policeToolStripMenuItem});
            this.formatsToolStripMenuItem.Name = "formatsToolStripMenuItem";
            this.formatsToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.formatsToolStripMenuItem.Text = "Forma&t";
            // 
            // policeToolStripMenuItem
            // 
            this.policeToolStripMenuItem.Image = global::AuteursMangas.Properties.Resources.letter_A;
            this.policeToolStripMenuItem.Name = "policeToolStripMenuItem";
            this.policeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.policeToolStripMenuItem.Text = "&Police...";
            this.policeToolStripMenuItem.Click += new System.EventHandler(this.policeToolStripMenuItem_Click);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirUnePhotoToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 34);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // ouvrirUnePhotoToolStripMenuItem
            // 
            this.ouvrirUnePhotoToolStripMenuItem.Name = "ouvrirUnePhotoToolStripMenuItem";
            this.ouvrirUnePhotoToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.ouvrirUnePhotoToolStripMenuItem.Text = "&Ouvrir une photo...";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(70, 34);
            this.formatToolStripMenuItem.Text = "Forma&t";
            // 
            // mangasLabel
            // 
            this.mangasLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangasLabel.Location = new System.Drawing.Point(22, 61);
            this.mangasLabel.Name = "mangasLabel";
            this.mangasLabel.Size = new System.Drawing.Size(215, 54);
            this.mangasLabel.TabIndex = 2;
            this.mangasLabel.Text = "Mangas";
            // 
            // AuteursLabel
            // 
            this.AuteursLabel.Location = new System.Drawing.Point(15, 336);
            this.AuteursLabel.Name = "AuteursLabel";
            this.AuteursLabel.Size = new System.Drawing.Size(275, 29);
            this.AuteursLabel.TabIndex = 4;
            this.AuteursLabel.Text = "Auteurs:";
            // 
            // mangas
            // 
            this.mangas.Location = new System.Drawing.Point(327, 336);
            this.mangas.Name = "mangas";
            this.mangas.Size = new System.Drawing.Size(51, 17);
            this.mangas.TabIndex = 6;
            this.mangas.Text = "Mangas:";
            // 
            // listeImagesLabel
            // 
            this.listeImagesLabel.Location = new System.Drawing.Point(327, 99);
            this.listeImagesLabel.Name = "listeImagesLabel";
            this.listeImagesLabel.Size = new System.Drawing.Size(222, 16);
            this.listeImagesLabel.TabIndex = 8;
            this.listeImagesLabel.Text = "Liste d\'images:";
            // 
            // imageLabel
            // 
            this.imageLabel.Location = new System.Drawing.Point(654, 99);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(264, 16);
            this.imageLabel.TabIndex = 9;
            this.imageLabel.Text = "Images:";
            // 
            // auteursTextBox
            // 
            this.auteursTextBox.Location = new System.Drawing.Point(18, 368);
            this.auteursTextBox.Multiline = true;
            this.auteursTextBox.Name = "auteursTextBox";
            this.auteursTextBox.Size = new System.Drawing.Size(306, 289);
            this.auteursTextBox.TabIndex = 11;
            this.auteursTextBox.Text = resources.GetString("auteursTextBox.Text");
            // 
            // mangasListBox
            // 
            this.mangasListBox.FormattingEnabled = true;
            this.mangasListBox.ItemHeight = 16;
            this.mangasListBox.Location = new System.Drawing.Point(330, 368);
            this.mangasListBox.Name = "mangasListBox";
            this.mangasListBox.Size = new System.Drawing.Size(219, 292);
            this.mangasListBox.TabIndex = 12;
            // 
            // resultatListBox
            // 
            this.resultatListBox.FormattingEnabled = true;
            this.resultatListBox.ItemHeight = 16;
            this.resultatListBox.Location = new System.Drawing.Point(727, 368);
            this.resultatListBox.Name = "resultatListBox";
            this.resultatListBox.Size = new System.Drawing.Size(219, 292);
            this.resultatListBox.TabIndex = 13;
            // 
            // pairButton
            // 
            this.pairButton.Location = new System.Drawing.Point(568, 480);
            this.pairButton.Name = "pairButton";
            this.pairButton.Size = new System.Drawing.Size(141, 64);
            this.pairButton.TabIndex = 15;
            this.pairButton.Text = "Pair";
            this.pairButton.UseVisualStyleBackColor = true;
            this.pairButton.Click += new System.EventHandler(this.pairButton_Click);
            // 
            // impairButton
            // 
            this.impairButton.Location = new System.Drawing.Point(568, 563);
            this.impairButton.Name = "impairButton";
            this.impairButton.Size = new System.Drawing.Size(141, 64);
            this.impairButton.TabIndex = 16;
            this.impairButton.Text = "Impair";
            this.impairButton.UseVisualStyleBackColor = true;
            this.impairButton.Click += new System.EventHandler(this.impairButton_Click);
            // 
            // listeImagesListBox
            // 
            this.listeImagesListBox.FormattingEnabled = true;
            this.listeImagesListBox.ItemHeight = 16;
            this.listeImagesListBox.Location = new System.Drawing.Point(330, 132);
            this.listeImagesListBox.Name = "listeImagesListBox";
            this.listeImagesListBox.Size = new System.Drawing.Size(321, 180);
            this.listeImagesListBox.TabIndex = 17;
            // 
            // auteursMangasOpenFileDialog
            // 
            this.auteursMangasOpenFileDialog.FileName = "openFileDialog1";
            // 
            // selectButton
            // 
            this.selectButton.Image = global::AuteursMangas.Properties.Resources.Arrow;
            this.selectButton.Location = new System.Drawing.Point(568, 395);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(141, 64);
            this.selectButton.TabIndex = 14;
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // imagesPictureBox
            // 
            this.imagesPictureBox.Location = new System.Drawing.Point(657, 132);
            this.imagesPictureBox.Name = "imagesPictureBox";
            this.imagesPictureBox.Size = new System.Drawing.Size(289, 180);
            this.imagesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagesPictureBox.TabIndex = 10;
            this.imagesPictureBox.TabStop = false;
            // 
            // auteursMangasPictureBox
            // 
            this.auteursMangasPictureBox.Image = global::AuteursMangas.Properties.Resources.otaku;
            this.auteursMangasPictureBox.Location = new System.Drawing.Point(18, 132);
            this.auteursMangasPictureBox.Name = "auteursMangasPictureBox";
            this.auteursMangasPictureBox.Size = new System.Drawing.Size(249, 180);
            this.auteursMangasPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.auteursMangasPictureBox.TabIndex = 3;
            this.auteursMangasPictureBox.TabStop = false;
            // 
            // AuteursMangasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 702);
            this.Controls.Add(this.listeImagesListBox);
            this.Controls.Add(this.impairButton);
            this.Controls.Add(this.pairButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.resultatListBox);
            this.Controls.Add(this.mangasListBox);
            this.Controls.Add(this.auteursTextBox);
            this.Controls.Add(this.imagesPictureBox);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.listeImagesLabel);
            this.Controls.Add(this.mangas);
            this.Controls.Add(this.AuteursLabel);
            this.Controls.Add(this.auteursMangasPictureBox);
            this.Controls.Add(this.mangasLabel);
            this.Controls.Add(this.auteursMangasMenuStrip);
            this.MainMenuStrip = this.auteursMangasMenuStrip;
            this.Name = "AuteursMangasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auteurs et Mangas";
            this.Load += new System.EventHandler(this.AuteursMangasForm_Load);
            this.auteursMangasMenuStrip.ResumeLayout(false);
            this.auteursMangasMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auteursMangasPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip auteursMangasMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirUnePhotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.Label mangasLabel;
        private System.Windows.Forms.PictureBox auteursMangasPictureBox;
        private System.Windows.Forms.Label AuteursLabel;
        private System.Windows.Forms.Label mangas;
        private System.Windows.Forms.Label listeImagesLabel;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.PictureBox imagesPictureBox;
        private System.Windows.Forms.TextBox auteursTextBox;
        private System.Windows.Forms.ListBox mangasListBox;
        private System.Windows.Forms.ListBox resultatListBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button pairButton;
        private System.Windows.Forms.Button impairButton;
        private System.Windows.Forms.ListBox listeImagesListBox;
        private System.Windows.Forms.ToolStripMenuItem fichiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirUnePhotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog auteursMangasOpenFileDialog;
        private System.Windows.Forms.FontDialog auteursMangasFontDialog;
    }
}

