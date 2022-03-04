using System;
using System.ComponentModel;

namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запишиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запишиКатоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отвориToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цвятНаЗапълванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.случаенЦвятНаЗапълванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слуаенЦвятНаЛиниитеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.случайниЦветовеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фигуриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.селекцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правоъгълникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кръгToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.елипсаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.манипулацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уголемяванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.намаляванеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изтриванеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.случайниЦветовеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копирайToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уголемиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.намаляванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изтриванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.транспарантноЗапълванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.транспаратноЗапълванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.обектToolStripMenuItem,
            this.фигуриToolStripMenuItem,
            this.манипулацииToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(924, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запишиToolStripMenuItem,
            this.запишиКатоToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.отвориToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // запишиToolStripMenuItem
            // 
            this.запишиToolStripMenuItem.Name = "запишиToolStripMenuItem";
            this.запишиToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.запишиToolStripMenuItem.Text = "Запиши";
            this.запишиToolStripMenuItem.Click += new System.EventHandler(this.запишиToolStripMenuItem_Click);
            // 
            // запишиКатоToolStripMenuItem
            // 
            this.запишиКатоToolStripMenuItem.Name = "запишиКатоToolStripMenuItem";
            this.запишиКатоToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.запишиКатоToolStripMenuItem.Text = "Запиши като..";
            this.запишиКатоToolStripMenuItem.Click += new System.EventHandler(this.запишиКатоToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.exitToolStripMenuItem.Text = "Изход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // отвориToolStripMenuItem
            // 
            this.отвориToolStripMenuItem.Name = "отвориToolStripMenuItem";
            this.отвориToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.отвориToolStripMenuItem.Text = "Отвори";
            this.отвориToolStripMenuItem.Click += new System.EventHandler(this.отвориToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // обектToolStripMenuItem
            // 
            this.обектToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цToolStripMenuItem,
            this.цвятНаЗапълванеToolStripMenuItem,
            this.случаенЦвятНаЗапълванеToolStripMenuItem,
            this.слуаенЦвятНаЛиниитеToolStripMenuItem,
            this.случайниЦветовеToolStripMenuItem,
            this.транспаратноЗапълванеToolStripMenuItem});
            this.обектToolStripMenuItem.Name = "обектToolStripMenuItem";
            this.обектToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.обектToolStripMenuItem.Text = "Инструменти";
            // 
            // цToolStripMenuItem
            // 
            this.цToolStripMenuItem.Name = "цToolStripMenuItem";
            this.цToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.цToolStripMenuItem.Text = "Цвят на линиите";
            this.цToolStripMenuItem.Click += new System.EventHandler(this.цToolStripMenuItem_Click);
            // 
            // цвятНаЗапълванеToolStripMenuItem
            // 
            this.цвятНаЗапълванеToolStripMenuItem.Name = "цвятНаЗапълванеToolStripMenuItem";
            this.цвятНаЗапълванеToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.цвятНаЗапълванеToolStripMenuItem.Text = "Цвят на запълване";
            this.цвятНаЗапълванеToolStripMenuItem.Click += new System.EventHandler(this.ЦвятНаЗапълванеToolStripMenuItem_Click);
            // 
            // случаенЦвятНаЗапълванеToolStripMenuItem
            // 
            this.случаенЦвятНаЗапълванеToolStripMenuItem.Name = "случаенЦвятНаЗапълванеToolStripMenuItem";
            this.случаенЦвятНаЗапълванеToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.случаенЦвятНаЗапълванеToolStripMenuItem.Text = "Случаен цвят на запълване";
            this.случаенЦвятНаЗапълванеToolStripMenuItem.Click += new System.EventHandler(this.случаенЦвятНаЗапълванеToolStripMenuItem_Click);
            // 
            // слуаенЦвятНаЛиниитеToolStripMenuItem
            // 
            this.слуаенЦвятНаЛиниитеToolStripMenuItem.Name = "слуаенЦвятНаЛиниитеToolStripMenuItem";
            this.слуаенЦвятНаЛиниитеToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.слуаенЦвятНаЛиниитеToolStripMenuItem.Text = "Слуаен цвят на линиите";
            this.слуаенЦвятНаЛиниитеToolStripMenuItem.Click += new System.EventHandler(this.слуаенЦвятНаЛиниитеToolStripMenuItem_Click);
            // 
            // случайниЦветовеToolStripMenuItem
            // 
            this.случайниЦветовеToolStripMenuItem.Name = "случайниЦветовеToolStripMenuItem";
            this.случайниЦветовеToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.случайниЦветовеToolStripMenuItem.Text = "Случайни Цветове";
            this.случайниЦветовеToolStripMenuItem.Click += new System.EventHandler(this.случайниЦветовеToolStripMenuItem_Click);
            // 
            // фигуриToolStripMenuItem
            // 
            this.фигуриToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.селекцияToolStripMenuItem,
            this.правоъгълникToolStripMenuItem,
            this.кръгToolStripMenuItem,
            this.линияToolStripMenuItem,
            this.елипсаToolStripMenuItem});
            this.фигуриToolStripMenuItem.Name = "фигуриToolStripMenuItem";
            this.фигуриToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.фигуриToolStripMenuItem.Text = "Фигури";
            // 
            // селекцияToolStripMenuItem
            // 
            this.селекцияToolStripMenuItem.Name = "селекцияToolStripMenuItem";
            this.селекцияToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.селекцияToolStripMenuItem.Text = "Селекция";
            this.селекцияToolStripMenuItem.Click += new System.EventHandler(this.СелекцияToolStripMenuItem_Click);
            // 
            // правоъгълникToolStripMenuItem
            // 
            this.правоъгълникToolStripMenuItem.Name = "правоъгълникToolStripMenuItem";
            this.правоъгълникToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.правоъгълникToolStripMenuItem.Text = "Правоъгълник";
            this.правоъгълникToolStripMenuItem.Click += new System.EventHandler(this.ПравоъгълникToolStripMenuItem_Click);
            // 
            // кръгToolStripMenuItem
            // 
            this.кръгToolStripMenuItem.Name = "кръгToolStripMenuItem";
            this.кръгToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.кръгToolStripMenuItem.Text = "Кръг";
            this.кръгToolStripMenuItem.Click += new System.EventHandler(this.КръгToolStripMenuItem_Click);
            // 
            // линияToolStripMenuItem
            // 
            this.линияToolStripMenuItem.Name = "линияToolStripMenuItem";
            this.линияToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.линияToolStripMenuItem.Text = "Линия";
            this.линияToolStripMenuItem.Click += new System.EventHandler(this.ЛинияToolStripMenuItem_Click);
            // 
            // елипсаToolStripMenuItem
            // 
            this.елипсаToolStripMenuItem.Name = "елипсаToolStripMenuItem";
            this.елипсаToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.елипсаToolStripMenuItem.Text = "Елипса";
            this.елипсаToolStripMenuItem.Click += new System.EventHandler(this.елипсаToolStripMenuItem_Click);
            // 
            // манипулацииToolStripMenuItem
            // 
            this.манипулацииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.уголемяванеToolStripMenuItem,
            this.намаляванеToolStripMenuItem1,
            this.изтриванеToolStripMenuItem1});
            this.манипулацииToolStripMenuItem.Name = "манипулацииToolStripMenuItem";
            this.манипулацииToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.манипулацииToolStripMenuItem.Text = "Манипулации";
            // 
            // уголемяванеToolStripMenuItem
            // 
            this.уголемяванеToolStripMenuItem.Name = "уголемяванеToolStripMenuItem";
            this.уголемяванеToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.уголемяванеToolStripMenuItem.Text = "Уголемяване";
            this.уголемяванеToolStripMenuItem.Click += new System.EventHandler(this.уголемяванеToolStripMenuItem_Click);
            // 
            // намаляванеToolStripMenuItem1
            // 
            this.намаляванеToolStripMenuItem1.Name = "намаляванеToolStripMenuItem1";
            this.намаляванеToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.намаляванеToolStripMenuItem1.Text = "Намаляване";
            this.намаляванеToolStripMenuItem1.Click += new System.EventHandler(this.намаляванеToolStripMenuItem1_Click);
            // 
            // изтриванеToolStripMenuItem1
            // 
            this.изтриванеToolStripMenuItem1.Name = "изтриванеToolStripMenuItem1";
            this.изтриванеToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.изтриванеToolStripMenuItem1.Text = "Изтриване";
            this.изтриванеToolStripMenuItem1.Click += new System.EventHandler(this.изтриванеToolStripMenuItem1_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 499);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(924, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // speedMenu
            // 
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton8,
            this.drawRectangleSpeedButton,
            this.pickUpSpeedButton,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton9});
            this.speedMenu.Location = new System.Drawing.Point(0, 28);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(924, 27);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton8.Text = "toolStripButton8";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(29, 24);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(29, 24);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click_1);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton9.Text = "toolStripButton9";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.случайниЦветовеToolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.копирайToolStripMenuItem,
            this.транспарантноЗапълванеToolStripMenuItem,
            this.уголемиToolStripMenuItem,
            this.намаляванеToolStripMenuItem,
            this.изтриванеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(265, 172);
            // 
            // случайниЦветовеToolStripMenuItem1
            // 
            this.случайниЦветовеToolStripMenuItem1.Name = "случайниЦветовеToolStripMenuItem1";
            this.случайниЦветовеToolStripMenuItem1.Size = new System.Drawing.Size(264, 24);
            this.случайниЦветовеToolStripMenuItem1.Text = "Случайни цветове";
            this.случайниЦветовеToolStripMenuItem1.Click += new System.EventHandler(this.случайниЦветовеToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.deleteToolStripMenuItem.Text = "Цвят на запълване";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // копирайToolStripMenuItem
            // 
            this.копирайToolStripMenuItem.Name = "копирайToolStripMenuItem";
            this.копирайToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.копирайToolStripMenuItem.Text = "Цвят на линиите";
            this.копирайToolStripMenuItem.Click += new System.EventHandler(this.копирайToolStripMenuItem_Click);
            // 
            // уголемиToolStripMenuItem
            // 
            this.уголемиToolStripMenuItem.Name = "уголемиToolStripMenuItem";
            this.уголемиToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.уголемиToolStripMenuItem.Text = "Уголемяване";
            this.уголемиToolStripMenuItem.Click += new System.EventHandler(this.уголемиToolStripMenuItem_Click);
            // 
            // намаляванеToolStripMenuItem
            // 
            this.намаляванеToolStripMenuItem.Name = "намаляванеToolStripMenuItem";
            this.намаляванеToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.намаляванеToolStripMenuItem.Text = "Намаляване";
            this.намаляванеToolStripMenuItem.Click += new System.EventHandler(this.намаляванеToolStripMenuItem_Click);
            // 
            // изтриванеToolStripMenuItem
            // 
            this.изтриванеToolStripMenuItem.Name = "изтриванеToolStripMenuItem";
            this.изтриванеToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.изтриванеToolStripMenuItem.Text = "Изтриване";
            this.изтриванеToolStripMenuItem.Click += new System.EventHandler(this.изтриванеToolStripMenuItem_Click);
            // 
            // транспарантноЗапълванеToolStripMenuItem
            // 
            this.транспарантноЗапълванеToolStripMenuItem.Name = "транспарантноЗапълванеToolStripMenuItem";
            this.транспарантноЗапълванеToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.транспарантноЗапълванеToolStripMenuItem.Text = "Транспарантно запълване";
            this.транспарантноЗапълванеToolStripMenuItem.Click += new System.EventHandler(this.транспарантноЗапълванеToolStripMenuItem_Click);
            // 
            // viewPort
            // 
            this.viewPort.BackColor = System.Drawing.Color.Transparent;
            this.viewPort.ContextMenuStrip = this.contextMenuStrip1;
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 55);
            this.viewPort.Margin = new System.Windows.Forms.Padding(5);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(924, 444);
            this.viewPort.TabIndex = 4;
            this.viewPort.Load += new System.EventHandler(this.viewPort_Load);
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // транспаратноЗапълванеToolStripMenuItem
            // 
            this.транспаратноЗапълванеToolStripMenuItem.Name = "транспаратноЗапълванеToolStripMenuItem";
            this.транспаратноЗапълванеToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.транспаратноЗапълванеToolStripMenuItem.Text = "Транспаратно Запълване";
            this.транспаратноЗапълванеToolStripMenuItem.Click += new System.EventHandler(this.транспаратноЗапълванеToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private void viewPort_Load(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem обектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цвятНаЗапълванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фигуриToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem селекцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правоъгълникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кръгToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem елипсаToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem случаенЦвятНаЗапълванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem слуаенЦвятНаЛиниитеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem случайниЦветовеToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копирайToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem уголемиToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem намаляванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem случайниЦветовеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem манипулацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уголемяванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem намаляванеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изтриванеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изтриванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запишиКатоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запишиToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripMenuItem отвориToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem транспарантноЗапълванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem транспаратноЗапълванеToolStripMenuItem;
    }
}
