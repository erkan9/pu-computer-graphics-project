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
            this.отвориToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цвятНаЗапълванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.случаенЦвятНаЗапълванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слуаенЦвятНаЛиниитеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.случайниЦветовеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.транспаратноЗапълванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фигуриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.селекцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правоъгълникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кръгToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.елипсаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правоъгълникСДиагоналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.манипулацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уголемяванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.намаляванеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.завъртанеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изтриванеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.копиранеНаПравоъгълникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копиранеКатоКръгToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копиранеКатоЕлипсаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.избериЧрезToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имеНаФигураToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.манипулацияНаГрупиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.смениЦветаНаГрупаRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.смениЦветаНаГрупаCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.смениЦветаНаДругаГрупаToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.завъртанеНаГрупаToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.размериToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.намаляванеToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.случайниЦветовеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копирайToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.транспарантноЗапълванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уголемиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.намаляванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завъртанеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изтриванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копирайПравоъгълникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копирайКатоКръгToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копирайКатоЕлипсаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.именуванеНаФигуратаToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.промениГрупатаToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.премахниОтГрупатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.увеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.групаToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
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
            this.обектToolStripMenuItem,
            this.фигуриToolStripMenuItem,
            this.манипулацииToolStripMenuItem,
            this.избериЧрезToolStripMenuItem,
            this.манипулацияНаГрупиToolStripMenuItem,
            this.helpToolStripMenuItem});
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
            this.отвориToolStripMenuItem,
            this.новToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // запишиToolStripMenuItem
            // 
            this.запишиToolStripMenuItem.Name = "запишиToolStripMenuItem";
            this.запишиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.запишиToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.запишиToolStripMenuItem.Text = "Запиши";
            this.запишиToolStripMenuItem.Click += new System.EventHandler(this.запишиToolStripMenuItem_Click);
            // 
            // запишиКатоToolStripMenuItem
            // 
            this.запишиКатоToolStripMenuItem.Name = "запишиКатоToolStripMenuItem";
            this.запишиКатоToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.запишиКатоToolStripMenuItem.Text = "Запиши като..";
            this.запишиКатоToolStripMenuItem.Click += new System.EventHandler(this.запишиКатоToolStripMenuItem_Click);
            // 
            // отвориToolStripMenuItem
            // 
            this.отвориToolStripMenuItem.Name = "отвориToolStripMenuItem";
            this.отвориToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.отвориToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.отвориToolStripMenuItem.Text = "Отвори";
            this.отвориToolStripMenuItem.Click += new System.EventHandler(this.отвориToolStripMenuItem_Click);
            // 
            // новToolStripMenuItem
            // 
            this.новToolStripMenuItem.Name = "новToolStripMenuItem";
            this.новToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.новToolStripMenuItem.Text = "Цвят на заден фон";
            this.новToolStripMenuItem.Click += new System.EventHandler(this.новToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.exitToolStripMenuItem.Text = "Изход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
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
            // транспаратноЗапълванеToolStripMenuItem
            // 
            this.транспаратноЗапълванеToolStripMenuItem.Name = "транспаратноЗапълванеToolStripMenuItem";
            this.транспаратноЗапълванеToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.транспаратноЗапълванеToolStripMenuItem.Text = "Прозрачно запълване";
            this.транспаратноЗапълванеToolStripMenuItem.Click += new System.EventHandler(this.транспаратноЗапълванеToolStripMenuItem_Click);
            // 
            // фигуриToolStripMenuItem
            // 
            this.фигуриToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.селекцияToolStripMenuItem,
            this.правоъгълникToolStripMenuItem,
            this.кръгToolStripMenuItem,
            this.линияToolStripMenuItem,
            this.елипсаToolStripMenuItem,
            this.правоъгълникСДиагоналToolStripMenuItem});
            this.фигуриToolStripMenuItem.Name = "фигуриToolStripMenuItem";
            this.фигуриToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.фигуриToolStripMenuItem.Text = "Фигури";
            // 
            // селекцияToolStripMenuItem
            // 
            this.селекцияToolStripMenuItem.Name = "селекцияToolStripMenuItem";
            this.селекцияToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.селекцияToolStripMenuItem.Text = "Селекция";
            this.селекцияToolStripMenuItem.Click += new System.EventHandler(this.СелекцияToolStripMenuItem_Click);
            // 
            // правоъгълникToolStripMenuItem
            // 
            this.правоъгълникToolStripMenuItem.Name = "правоъгълникToolStripMenuItem";
            this.правоъгълникToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.правоъгълникToolStripMenuItem.Text = "Правоъгълник";
            this.правоъгълникToolStripMenuItem.Click += new System.EventHandler(this.ПравоъгълникToolStripMenuItem_Click);
            // 
            // кръгToolStripMenuItem
            // 
            this.кръгToolStripMenuItem.Name = "кръгToolStripMenuItem";
            this.кръгToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.кръгToolStripMenuItem.Text = "Кръг";
            this.кръгToolStripMenuItem.Click += new System.EventHandler(this.КръгToolStripMenuItem_Click);
            // 
            // линияToolStripMenuItem
            // 
            this.линияToolStripMenuItem.Name = "линияToolStripMenuItem";
            this.линияToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.линияToolStripMenuItem.Text = "Линия";
            this.линияToolStripMenuItem.Click += new System.EventHandler(this.ЛинияToolStripMenuItem_Click);
            // 
            // елипсаToolStripMenuItem
            // 
            this.елипсаToolStripMenuItem.Name = "елипсаToolStripMenuItem";
            this.елипсаToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.елипсаToolStripMenuItem.Text = "Елипса";
            this.елипсаToolStripMenuItem.Click += new System.EventHandler(this.елипсаToolStripMenuItem_Click);
            // 
            // правоъгълникСДиагоналToolStripMenuItem
            // 
            this.правоъгълникСДиагоналToolStripMenuItem.Name = "правоъгълникСДиагоналToolStripMenuItem";
            this.правоъгълникСДиагоналToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.правоъгълникСДиагоналToolStripMenuItem.Text = "Правоъгълник с Диагонал";
            this.правоъгълникСДиагоналToolStripMenuItem.Click += new System.EventHandler(this.правоъгълникСДиагоналToolStripMenuItem_Click);
            // 
            // манипулацииToolStripMenuItem
            // 
            this.манипулацииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.уголемяванеToolStripMenuItem,
            this.намаляванеToolStripMenuItem1,
            this.завъртанеToolStripMenuItem,
            this.изтриванеToolStripMenuItem1,
            this.копиранеНаПравоъгълникToolStripMenuItem,
            this.копиранеКатоКръгToolStripMenuItem,
            this.копиранеКатоЕлипсаToolStripMenuItem});
            this.манипулацииToolStripMenuItem.Name = "манипулацииToolStripMenuItem";
            this.манипулацииToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.манипулацииToolStripMenuItem.Text = "Манипулации";
            // 
            // уголемяванеToolStripMenuItem
            // 
            this.уголемяванеToolStripMenuItem.Name = "уголемяванеToolStripMenuItem";
            this.уголемяванеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.уголемяванеToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.уголемяванеToolStripMenuItem.Text = "Уголемяване";
            this.уголемяванеToolStripMenuItem.Click += new System.EventHandler(this.уголемяванеToolStripMenuItem_Click);
            // 
            // намаляванеToolStripMenuItem1
            // 
            this.намаляванеToolStripMenuItem1.Name = "намаляванеToolStripMenuItem1";
            this.намаляванеToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.намаляванеToolStripMenuItem1.Size = new System.Drawing.Size(302, 26);
            this.намаляванеToolStripMenuItem1.Text = "Намаляване";
            this.намаляванеToolStripMenuItem1.Click += new System.EventHandler(this.намаляванеToolStripMenuItem1_Click);
            // 
            // завъртанеToolStripMenuItem
            // 
            this.завъртанеToolStripMenuItem.Name = "завъртанеToolStripMenuItem";
            this.завъртанеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.завъртанеToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.завъртанеToolStripMenuItem.Text = "Завъртане";
            this.завъртанеToolStripMenuItem.Click += new System.EventHandler(this.завъртанеToolStripMenuItem_Click);
            // 
            // изтриванеToolStripMenuItem1
            // 
            this.изтриванеToolStripMenuItem1.Name = "изтриванеToolStripMenuItem1";
            this.изтриванеToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.изтриванеToolStripMenuItem1.Size = new System.Drawing.Size(302, 26);
            this.изтриванеToolStripMenuItem1.Text = "Изтриване";
            this.изтриванеToolStripMenuItem1.Click += new System.EventHandler(this.изтриванеToolStripMenuItem1_Click);
            // 
            // копиранеНаПравоъгълникToolStripMenuItem
            // 
            this.копиранеНаПравоъгълникToolStripMenuItem.Name = "копиранеНаПравоъгълникToolStripMenuItem";
            this.копиранеНаПравоъгълникToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.копиранеНаПравоъгълникToolStripMenuItem.Text = "Копиране като Правоъгълник";
            this.копиранеНаПравоъгълникToolStripMenuItem.Click += new System.EventHandler(this.копиранеНаПравоъгълникToolStripMenuItem_Click);
            // 
            // копиранеКатоКръгToolStripMenuItem
            // 
            this.копиранеКатоКръгToolStripMenuItem.Name = "копиранеКатоКръгToolStripMenuItem";
            this.копиранеКатоКръгToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.копиранеКатоКръгToolStripMenuItem.Text = "Копиране като Кръг";
            this.копиранеКатоКръгToolStripMenuItem.Click += new System.EventHandler(this.копиранеКатоКръгToolStripMenuItem_Click);
            // 
            // копиранеКатоЕлипсаToolStripMenuItem
            // 
            this.копиранеКатоЕлипсаToolStripMenuItem.Name = "копиранеКатоЕлипсаToolStripMenuItem";
            this.копиранеКатоЕлипсаToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.копиранеКатоЕлипсаToolStripMenuItem.Text = "Копиране като Елипса";
            this.копиранеКатоЕлипсаToolStripMenuItem.Click += new System.EventHandler(this.копиранеКатоЕлипсаToolStripMenuItem_Click);
            // 
            // избериЧрезToolStripMenuItem
            // 
            this.избериЧрезToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.имеНаФигураToolStripMenuItem});
            this.избериЧрезToolStripMenuItem.Name = "избериЧрезToolStripMenuItem";
            this.избериЧрезToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.избериЧрезToolStripMenuItem.Text = "Избор чрез име";
            this.избериЧрезToolStripMenuItem.Click += new System.EventHandler(this.избериЧрезToolStripMenuItem_Click);
            // 
            // имеНаФигураToolStripMenuItem
            // 
            this.имеНаФигураToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.имеНаФигураToolStripMenuItem.Name = "имеНаФигураToolStripMenuItem";
            this.имеНаФигураToolStripMenuItem.Size = new System.Drawing.Size(224, 27);
            this.имеНаФигураToolStripMenuItem.Text = "Име на фигура";
            this.имеНаФигураToolStripMenuItem.Click += new System.EventHandler(this.имеНаФигураToolStripMenuItem_Click);
            // 
            // манипулацияНаГрупиToolStripMenuItem
            // 
            this.манипулацияНаГрупиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.смениЦветаНаГрупаRToolStripMenuItem,
            this.смениЦветаНаГрупаCToolStripMenuItem,
            this.смениЦветаНаДругаГрупаToolStripMenuItem,
            this.завъртанеНаГрупаToolStripMenuItem,
            this.размериToolStripMenuItem});
            this.манипулацияНаГрупиToolStripMenuItem.Name = "манипулацияНаГрупиToolStripMenuItem";
            this.манипулацияНаГрупиToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.манипулацияНаГрупиToolStripMenuItem.Text = "Манипулация на Групи";
            // 
            // смениЦветаНаГрупаRToolStripMenuItem
            // 
            this.смениЦветаНаГрупаRToolStripMenuItem.Name = "смениЦветаНаГрупаRToolStripMenuItem";
            this.смениЦветаНаГрупаRToolStripMenuItem.Size = new System.Drawing.Size(437, 26);
            this.смениЦветаНаГрупаRToolStripMenuItem.Text = "Смени цвета на група A";
            this.смениЦветаНаГрупаRToolStripMenuItem.Click += new System.EventHandler(this.смениЦветаНаГрупаRToolStripMenuItem_Click);
            // 
            // смениЦветаНаГрупаCToolStripMenuItem
            // 
            this.смениЦветаНаГрупаCToolStripMenuItem.Name = "смениЦветаНаГрупаCToolStripMenuItem";
            this.смениЦветаНаГрупаCToolStripMenuItem.Size = new System.Drawing.Size(437, 26);
            this.смениЦветаНаГрупаCToolStripMenuItem.Text = "Смени Цвета на група B";
            this.смениЦветаНаГрупаCToolStripMenuItem.Click += new System.EventHandler(this.смениЦветаНаГрупаCToolStripMenuItem_Click);
            // 
            // смениЦветаНаДругаГрупаToolStripMenuItem
            // 
            this.смениЦветаНаДругаГрупаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.смениЦветаНаДругаГрупаToolStripMenuItem.Name = "смениЦветаНаДругаГрупаToolStripMenuItem";
            this.смениЦветаНаДругаГрупаToolStripMenuItem.Size = new System.Drawing.Size(289, 27);
            this.смениЦветаНаДругаГрупаToolStripMenuItem.Text = "Смени Цвета на друга група";
            this.смениЦветаНаДругаГрупаToolStripMenuItem.Click += new System.EventHandler(this.смениЦветаНаДругаГрупаToolStripMenuItem_Click);
            // 
            // завъртанеНаГрупаToolStripMenuItem
            // 
            this.завъртанеНаГрупаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.завъртанеНаГрупаToolStripMenuItem.Name = "завъртанеНаГрупаToolStripMenuItem";
            this.завъртанеНаГрупаToolStripMenuItem.Size = new System.Drawing.Size(363, 27);
            this.завъртанеНаГрупаToolStripMenuItem.Text = "Завъртане на група";
            this.завъртанеНаГрупаToolStripMenuItem.Click += new System.EventHandler(this.завъртанеНаГрупаToolStripMenuItem_Click);
            // 
            // размериToolStripMenuItem
            // 
            this.размериToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.увеToolStripMenuItem,
            this.намаляванеToolStripMenuItem2,
            this.групаToolStripMenuItem});
            this.размериToolStripMenuItem.Name = "размериToolStripMenuItem";
            this.размериToolStripMenuItem.Size = new System.Drawing.Size(437, 26);
            this.размериToolStripMenuItem.Text = "Размери на група";
            // 
            // намаляванеToolStripMenuItem2
            // 
            this.намаляванеToolStripMenuItem2.Name = "намаляванеToolStripMenuItem2";
            this.намаляванеToolStripMenuItem2.Size = new System.Drawing.Size(298, 26);
            this.намаляванеToolStripMenuItem2.Text = "Намаляване";
            this.намаляванеToolStripMenuItem2.Click += new System.EventHandler(this.намаляванеToolStripMenuItem2_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.helpToolStripMenuItem.Text = "За проекта";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "GitHub";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            this.toolStripButton9,
            this.toolStripButton8,
            this.toolStripButton10,
            this.toolStripButton11,
            this.pickUpSpeedButton,
            this.drawRectangleSpeedButton,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton5,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton6,
            this.toolStripTextBox2,
            this.toolStripTextBox1,
            this.toolStripSeparator1});
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
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton10.Text = "toolStripButton10";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton11.Text = "toolStripButton11";
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton11_Click_1);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(29, 24);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            this.pickUpSpeedButton.Click += new System.EventHandler(this.pickUpSpeedButton_Click);
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
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.завъртанеToolStripMenuItem1,
            this.изтриванеToolStripMenuItem,
            this.копирайПравоъгълникToolStripMenuItem,
            this.копирайКатоКръгToolStripMenuItem,
            this.копирайКатоЕлипсаToolStripMenuItem,
            this.именуванеНаФигуратаToolStripMenuItem,
            this.промениГрупатаToolStripMenuItem,
            this.премахниОтГрупатаToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(401, 350);
            // 
            // случайниЦветовеToolStripMenuItem1
            // 
            this.случайниЦветовеToolStripMenuItem1.Name = "случайниЦветовеToolStripMenuItem1";
            this.случайниЦветовеToolStripMenuItem1.Size = new System.Drawing.Size(400, 24);
            this.случайниЦветовеToolStripMenuItem1.Text = "Случайни цветове";
            this.случайниЦветовеToolStripMenuItem1.Click += new System.EventHandler(this.случайниЦветовеToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(400, 24);
            this.deleteToolStripMenuItem.Text = "Цвят на запълване";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // копирайToolStripMenuItem
            // 
            this.копирайToolStripMenuItem.Name = "копирайToolStripMenuItem";
            this.копирайToolStripMenuItem.Size = new System.Drawing.Size(400, 24);
            this.копирайToolStripMenuItem.Text = "Цвят на линиите";
            this.копирайToolStripMenuItem.Click += new System.EventHandler(this.копирайToolStripMenuItem_Click);
            // 
            // транспарантноЗапълванеToolStripMenuItem
            // 
            this.транспарантноЗапълванеToolStripMenuItem.Name = "транспарантноЗапълванеToolStripMenuItem";
            this.транспарантноЗапълванеToolStripMenuItem.Size = new System.Drawing.Size(400, 24);
            this.транспарантноЗапълванеToolStripMenuItem.Text = "Прозрачно запълване";
            this.транспарантноЗапълванеToolStripMenuItem.Click += new System.EventHandler(this.транспарантноЗапълванеToolStripMenuItem_Click);
            // 
            // уголемиToolStripMenuItem
            // 
            this.уголемиToolStripMenuItem.Name = "уголемиToolStripMenuItem";
            this.уголемиToolStripMenuItem.Size = new System.Drawing.Size(400, 24);
            this.уголемиToolStripMenuItem.Text = "Уголемяване";
            this.уголемиToolStripMenuItem.Click += new System.EventHandler(this.уголемиToolStripMenuItem_Click);
            // 
            // намаляванеToolStripMenuItem
            // 
            this.намаляванеToolStripMenuItem.Name = "намаляванеToolStripMenuItem";
            this.намаляванеToolStripMenuItem.Size = new System.Drawing.Size(400, 24);
            this.намаляванеToolStripMenuItem.Text = "Намаляване";
            this.намаляванеToolStripMenuItem.Click += new System.EventHandler(this.намаляванеToolStripMenuItem_Click);
            // 
            // завъртанеToolStripMenuItem1
            // 
            this.завъртанеToolStripMenuItem1.Name = "завъртанеToolStripMenuItem1";
            this.завъртанеToolStripMenuItem1.Size = new System.Drawing.Size(400, 24);
            this.завъртанеToolStripMenuItem1.Text = "Завъртане";
            this.завъртанеToolStripMenuItem1.Click += new System.EventHandler(this.завъртанеToolStripMenuItem1_Click);
            // 
            // изтриванеToolStripMenuItem
            // 
            this.изтриванеToolStripMenuItem.Name = "изтриванеToolStripMenuItem";
            this.изтриванеToolStripMenuItem.Size = new System.Drawing.Size(400, 24);
            this.изтриванеToolStripMenuItem.Text = "Изтриване";
            this.изтриванеToolStripMenuItem.Click += new System.EventHandler(this.изтриванеToolStripMenuItem_Click);
            // 
            // копирайПравоъгълникToolStripMenuItem
            // 
            this.копирайПравоъгълникToolStripMenuItem.Name = "копирайПравоъгълникToolStripMenuItem";
            this.копирайПравоъгълникToolStripMenuItem.Size = new System.Drawing.Size(400, 24);
            this.копирайПравоъгълникToolStripMenuItem.Text = "Копирай като Правоъгълник";
            this.копирайПравоъгълникToolStripMenuItem.Click += new System.EventHandler(this.копирайПравоъгълникToolStripMenuItem_Click);
            // 
            // копирайКатоКръгToolStripMenuItem
            // 
            this.копирайКатоКръгToolStripMenuItem.Name = "копирайКатоКръгToolStripMenuItem";
            this.копирайКатоКръгToolStripMenuItem.Size = new System.Drawing.Size(400, 24);
            this.копирайКатоКръгToolStripMenuItem.Text = "Копирай като Кръг";
            this.копирайКатоКръгToolStripMenuItem.Click += new System.EventHandler(this.копирайКатоКръгToolStripMenuItem_Click);
            // 
            // копирайКатоЕлипсаToolStripMenuItem
            // 
            this.копирайКатоЕлипсаToolStripMenuItem.Name = "копирайКатоЕлипсаToolStripMenuItem";
            this.копирайКатоЕлипсаToolStripMenuItem.Size = new System.Drawing.Size(400, 24);
            this.копирайКатоЕлипсаToolStripMenuItem.Text = "Копирай като Елипса";
            this.копирайКатоЕлипсаToolStripMenuItem.Click += new System.EventHandler(this.копирайКатоЕлипсаToolStripMenuItem_Click);
            // 
            // именуванеНаФигуратаToolStripMenuItem
            // 
            this.именуванеНаФигуратаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.именуванеНаФигуратаToolStripMenuItem.Name = "именуванеНаФигуратаToolStripMenuItem";
            this.именуванеНаФигуратаToolStripMenuItem.Size = new System.Drawing.Size(280, 27);
            this.именуванеНаФигуратаToolStripMenuItem.Text = "Именуване на фигурата";
            this.именуванеНаФигуратаToolStripMenuItem.Click += new System.EventHandler(this.именуванеНаФигуратаToolStripMenuItem_Click);
            // 
            // промениГрупатаToolStripMenuItem
            // 
            this.промениГрупатаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.промениГрупатаToolStripMenuItem.Name = "промениГрупатаToolStripMenuItem";
            this.промениГрупатаToolStripMenuItem.Size = new System.Drawing.Size(340, 27);
            this.промениГрупатаToolStripMenuItem.Text = "Промени Групата";
            this.промениГрупатаToolStripMenuItem.Click += new System.EventHandler(this.промениГрупатаToolStripMenuItem_Click);
            // 
            // премахниОтГрупатаToolStripMenuItem
            // 
            this.премахниОтГрупатаToolStripMenuItem.Name = "премахниОтГрупатаToolStripMenuItem";
            this.премахниОтГрупатаToolStripMenuItem.Size = new System.Drawing.Size(400, 24);
            this.премахниОтГрупатаToolStripMenuItem.Text = "Премахни от групата";
            this.премахниОтГрупатаToolStripMenuItem.Click += new System.EventHandler(this.премахниОтГрупатаToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            // увеToolStripMenuItem
            // 
            this.увеToolStripMenuItem.Name = "увеToolStripMenuItem";
            this.увеToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.увеToolStripMenuItem.Text = "Увеличаване";
            this.увеToolStripMenuItem.Click += new System.EventHandler(this.увеToolStripMenuItem_Click);
            // 
            // групаToolStripMenuItem
            // 
            this.групаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.групаToolStripMenuItem.Name = "групаToolStripMenuItem";
            this.групаToolStripMenuItem.Size = new System.Drawing.Size(224, 27);
            this.групаToolStripMenuItem.Text = "Група";
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
            this.Text = "Show";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem отвориToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem транспарантноЗапълванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem транспаратноЗапълванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завъртанеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завъртанеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripMenuItem новToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копиранеНаПравоъгълникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копирайПравоъгълникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копиранеКатоКръгToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копиранеКатоЕлипсаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копирайКатоКръгToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копирайКатоЕлипсаToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox именуванеНаФигуратаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem избериЧрезToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox имеНаФигураToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripMenuItem правоъгълникСДиагоналToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox промениГрупатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem манипулацияНаГрупиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem смениЦветаНаГрупаRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem смениЦветаНаГрупаCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox смениЦветаНаДругаГрупаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem премахниОтГрупатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox завъртанеНаГрупаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размериToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem намаляванеToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem увеToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox групаToolStripMenuItem;
    }
}
