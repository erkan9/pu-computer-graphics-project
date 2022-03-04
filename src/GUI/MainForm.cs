﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Draw
{
	/// <summary>
	/// Върху главната форма е поставен потребителски контрол,
	/// в който се осъществява визуализацията
	/// </summary>
	public partial class MainForm : Form
	{

		private Random rnd = new Random();

		/// <summary>
		/// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
		/// </summary>
		private DialogProcessor dialogProcessor = new DialogProcessor();

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		/// <summary>
		/// Изход от програмата. Затваря главната форма, а с това и програмата.
		/// </summary>
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		
		/// <summary>
		/// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
		/// </summary>
		void ViewPortPaint(object sender, PaintEventArgs e)
		{
			dialogProcessor.ReDraw(sender, e);
		}
		
		/// <summary>
		/// Бутон, който поставя на произволно място правоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{
			DrawRectangleOnClick();
		}

		/// <summary>
		/// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
		/// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
		/// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
		/// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
		/// </summary>
		void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{

			if (pickUpSpeedButton.Checked) 

			{
				dialogProcessor.Selection = dialogProcessor.ContainsPoint(e.Location);

				if (dialogProcessor.Selection != null) 
				{
					statusBar.Items[0].Text = "Последно действие: Селекция на примитив";

					dialogProcessor.IsDragging = true;

					dialogProcessor.LastLocation = e.Location;

					viewPort.Invalidate();
				}
			}
		}

		/// <summary>
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (dialogProcessor.IsDragging) {
				if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
				dialogProcessor.TranslateTo(e.Location);
				viewPort.Invalidate();
			}
		}

		/// <summary>
		/// Прихващане на отпускането на бутона на мишката.
		/// Излизаме от режим "влачене".
		/// </summary>
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dialogProcessor.IsDragging = false;
		}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

			DrawCircleOnClick();

		}

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
			ChangeFillColorOfFigure(sender,e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
			DrawLineOnClick();
		}

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
			ChangeStrokeColorOfFigure(sender, e);
		}

        private void цToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ChangeStrokeColorOfFigure(sender, e);
		}

        private void ЦвятНаЗапълванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ChangeFillColorOfFigure(sender, e);
		}

        private void СелекцияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ПравоъгълникToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DrawRectangleOnClick();
		}

        private void КръгToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DrawCircleOnClick();
		}

        private void ЛинияToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DrawLineOnClick();
		}

        private void елипсаToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DrawEllipseOnClick();
		}

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
			DrawEllipseOnClick();
		}

		private void DrawEllipseOnClick() 
		{
			dialogProcessor.AddEllipse();

			statusBar.Items[0].Text = "Последно действие: Рисуване на Елипса";

			viewPort.Invalidate();
		}

		private void DrawCircleOnClick() 
		{
			dialogProcessor.AddCircle();

			statusBar.Items[0].Text = "Последно действие: Рисуване на Кръг";

			viewPort.Invalidate();
		}

		private void DrawLineOnClick()
        {
			dialogProcessor.AddLine();

			statusBar.Items[0].Text = "Последно действие: Рисуване на Линия";

			viewPort.Invalidate();
		}

		private void DrawRectangleOnClick()
        {
			dialogProcessor.AddRandomRectangle();

			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

			viewPort.Invalidate();
		}

		private void ChangeFillColorOfFigure(object sender, EventArgs e)
        {
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				dialogProcessor.Selection.FillColor = colorDialog1.Color;

				viewPort.Invalidate();
			}
		}

		private void ChangeStrokeColorOfFigure(object sender, EventArgs e)
        {
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				dialogProcessor.Selection.StrokeColor = colorDialog1.Color;

				viewPort.Invalidate();
			}
		}

		private void ChangeFillColorRandomly()
        {
			Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

			dialogProcessor.Selection.FillColor = randomColor;
		}

		private void ChangeStrokeColorRandomly()
		{
			Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

			dialogProcessor.Selection.StrokeColor = randomColor;
		}

        private void случаенЦвятНаЗапълванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ChangeFillColorRandomly();

		}

        private void слуаенЦвятНаЛиниитеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ChangeStrokeColorRandomly();
		}

        private void случайниЦветовеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ChangeFillColorRandomly();
			ChangeStrokeColorRandomly();
		}

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
			ChangeFillColorRandomly();
			ChangeStrokeColorRandomly();
		}


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ChangeFillColorOfFigure(sender, e);
		}

        private void копирайToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ChangeStrokeColorOfFigure(sender, e);
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
			
		}

        private void уголемиToolStripMenuItem_Click(object sender, EventArgs e)
        {
		dialogProcessor.MakeFigureBigger();
		}

		//Save button
        private void toolStripButton7_Click(object sender, EventArgs e)
        {

			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			
			Graphics graphics = Graphics.FromImage(bitmap);

			Rectangle rectangle = base.RectangleToScreen(base.ClientRectangle);

			graphics.CopyFromScreen(rectangle.Location, Point.Empty, base.Size);

			graphics.Dispose();

			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";

			if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(saveFileDialog.FileName))
                {
					File.Delete(saveFileDialog.FileName);
                }

				if(saveFileDialog.FileName.Contains(".jpg"))
                {
					bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
				else if(saveFileDialog.FileName.Contains(".png"))
                {
					bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
				}
				else if(saveFileDialog.FileName.Contains(".bitmap"))
                {
					bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
				}
            }	
		}

		private void pictureBox1_Click(object sender, EventArgs e)
        {
			
        }

        private void намаляванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			dialogProcessor.MakeFigureSmaller();
		}

        private void случайниЦветовеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			ChangeFillColorRandomly();
			ChangeStrokeColorRandomly();
		}

        private void уголемяванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			dialogProcessor.MakeFigureBigger();
		}

        private void намаляванеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			dialogProcessor.MakeFigureSmaller();
		}

        private void изтриванеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			dialogProcessor.DeleteFigure();	
        }

        private void изтриванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			dialogProcessor.DeleteFigure();
		}

        private void запишиКатоToolStripMenuItem_Click(object sender, EventArgs e)
        {
			toolStripButton7_Click(sender, e);
		}

		private void запишиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(base.Width, base.Height);

			Graphics graphics = Graphics.FromImage(bitmap);

			Rectangle rectangle = base.RectangleToScreen(base.ClientRectangle);

			graphics.CopyFromScreen(rectangle.Location, Point.Empty, base.Size);

			graphics.Dispose();

			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.Filter = "|*.png";

			if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				if (File.Exists(saveFileDialog.FileName))
				{
					File.Delete(saveFileDialog.FileName);
				}

				bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
			}
		}

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog
            {
                Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp"
            };

            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                base.BackgroundImage = (Image)Image.FromFile(o.FileName).Clone();
            }
			base.Refresh();

		}

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
			
		}

        private void отвориToolStripMenuItem_Click(object sender, EventArgs e)
        {
			toolStripButton8_Click(sender, e);
		}

        private void транспарантноЗапълванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			dialogProcessor.Selection.FillColor = base.BackColor;
		}

        private void транспаратноЗапълванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			транспарантноЗапълванеToolStripMenuItem_Click(sender, e);

		}
    }
}