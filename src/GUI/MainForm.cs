using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Draw
{
    public partial class MainForm : Form
	{
        private readonly Random rnd = new Random();

		private readonly DialogProcessor dialogProcessor = new DialogProcessor();

		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Method that Exits and closes the Program.
		/// </summary>
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		
		/// <summary>
		/// Method that i used to visualise the Drawing Changes.
		/// </summary>
		void ViewPortPaint(object sender, PaintEventArgs e)
		{
			dialogProcessor.ReDraw(sender, e);
		}
		
		/// <summary>
		/// Method that Draws a Rectangle on click of a Button.
		/// </summary>
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{
			DrawRectangleOnClick();
		}

		/// <summary>
		/// Method that Checks if the click is aon  Figure. If true it starts Dragging the figure
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
		/// Method that follows the mouse if it is dragging a Figure
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (dialogProcessor.IsDragging)
			{
				if (dialogProcessor.Selection != null)
				{
					statusBar.Items[0].Text = "Последно действие: Влачене";
				}

				dialogProcessor.TranslateTo(e.Location);

				viewPort.Invalidate();
			}
		}

		/// <summary>
		/// Method that changes Dragging to false. When Mouse Clicks off.
		/// </summary>
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dialogProcessor.IsDragging = false;
		}

		/// <summary>
		/// Method that draws a Circle.
		/// </summary>
		private void toolStripButton1_Click(object sender, EventArgs e)
        {

			DrawCircleOnClick();

		}

		/// <summary>
		/// Method that changes the Fill Color of the Chosen Figure.
		/// </summary>
		private void toolStripButton2_Click(object sender, EventArgs e)
        {
			ChangeFillColorOfFigure();
        }


		/// <summary>
		/// Method that draws a Line.
		/// </summary>
		private void toolStripButton3_Click(object sender, EventArgs e)
        {
			DrawLineOnClick();
		}

		/// <summary>
		/// Method that changes the Stroke Color of the figure.
		/// </summary>
		private void toolStripButton4_Click(object sender, EventArgs e)
        {
			ChangeStrokeColorOfFigure();
		}

		/// <summary>
		/// Method that changes the Stroke Color of the figure.
		/// </summary>
		private void цToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ChangeStrokeColorOfFigure();
		}

		/// <summary>
		/// Method that changes the Fill Color of the Chosen Figure.
		/// </summary>
		private void ЦвятНаЗапълванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ChangeFillColorOfFigure();
		}

		private void СелекцияToolStripMenuItem_Click(object sender, EventArgs e) { }

		/// <summary>
		/// Method that Draws Rectangle on a click.
		/// </summary>
		private void ПравоъгълникToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DrawRectangleOnClick();
		}

		/// <summary>
		/// Method that Draws Circle on a click.
		/// </summary>
		private void КръгToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DrawCircleOnClick();
		}

		/// <summary>
		/// Method that Draws Line on a click.
		/// </summary>
		private void ЛинияToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DrawLineOnClick();
		}

		/// <summary>
		/// Method that Draws Ellipse on a click.
		/// </summary>
		private void елипсаToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DrawEllipseOnClick();
		}

		/// <summary>
		/// Method that Draws Ellipse on a click.
		/// </summary>
		private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
			DrawEllipseOnClick();
		}

		/// <summary>
		/// Method that Draws Ellipse.
		/// </summary>
		private void DrawEllipseOnClick() 
		{
			dialogProcessor.AddEllipse();

			statusBar.Items[0].Text = "Последно действие: Рисуване на Елипса";

			viewPort.Invalidate();
		}


		/// <summary>
		/// Method that Draws Circle.
		/// </summary>
		private void DrawCircleOnClick() 
		{
			dialogProcessor.AddCircle();

			statusBar.Items[0].Text = "Последно действие: Рисуване на Кръг";

			viewPort.Invalidate();
		}


		/// <summary>
		/// Method that Draws Line.
		/// </summary>
		private void DrawLineOnClick()
        {
			dialogProcessor.AddLine();

			statusBar.Items[0].Text = "Последно действие: Рисуване на Линия";

			viewPort.Invalidate();
		}


		/// <summary>
		/// Method that Draws Rectangle.
		/// </summary>
		private void DrawRectangleOnClick()
        {
			dialogProcessor.AddRandomRectangle();

			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

			viewPort.Invalidate();

			base.Invalidate();
		}


		/// <summary>
		/// Method that changes the Fill color of the selected figure.
		/// </summary>
		private void ChangeFillColorOfFigure()
        {
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				dialogProcessor.Selection.FillColor = colorDialog1.Color;

				statusBar.Items[0].Text = "Последно действие: Цвета на фигурата е сменена";
			}
			viewPort.Invalidate();
		}

		/// <summary>
		/// Method that changes the Stroke color of the selected figure.
		/// </summary>
		private void ChangeStrokeColorOfFigure()
        {
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				dialogProcessor.Selection.StrokeColor = colorDialog1.Color;

				statusBar.Items[0].Text = "Последно действие: Цвета на лиините на фигурата е сменена";
			}
			viewPort.Invalidate();
		}

		/// <summary>
		/// Method that changes Randomly the Fill color of the selected figure.
		/// </summary>
		private void ChangeFillColorRandomly()
        {
			Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

			statusBar.Items[0].Text = "Последно действие: Цвета на фигурата е сменена случайно";

			dialogProcessor.Selection.FillColor = randomColor;

			viewPort.Invalidate();
		}


		/// <summary>
		/// Method that changes Randomly the Stroke color of the selected figure.
		/// </summary>
		private void ChangeStrokeColorRandomly()
		{
			Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

			statusBar.Items[0].Text = "Последно действие: Цвета на лиините на фигурата е случайно";

			dialogProcessor.Selection.StrokeColor = randomColor;

			base.Invalidate();
		}



		/// <summary>
		/// Method that Deletes/Removes the chosen Figure.
		/// </summary>
		public void DeleteFigure()
		{

			dialogProcessor.ShapeList.Remove(dialogProcessor.Selection);

			base.Invalidate();
		}


		/// <summary>
		/// Method that changes Randomly the Fill color of the selected figure on Click.
		/// </summary>
		private void случаенЦвятНаЗапълванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ChangeFillColorRandomly();

		}

		/// <summary>
		/// Method that changes Randomly the Stroke color of the selected figure on Click.
		/// </summary>
		private void слуаенЦвятНаЛиниитеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ChangeStrokeColorRandomly();
		}

		/// <summary>
		/// Method that changes Randomly the Fill and Stroke color of the selected figure on Click.
		/// </summary>
		private void случайниЦветовеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ChangeFillColorRandomly();
			ChangeStrokeColorRandomly();
		}

		/// <summary>
		/// Method that changes Randomly the Fill color of the selected figure on Click.
		/// </summary>
		private void toolStripButton6_Click(object sender, EventArgs e)
        {
			ChangeFillColorRandomly();
			ChangeStrokeColorRandomly();
		}

		/// <summary>
		/// Method that changes the Fill color of the selected figure on Click.
		/// </summary>
		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ChangeFillColorOfFigure();
		}

		/// <summary>
		/// Method that changes the Stroke color of the selected figure on Click.
		/// </summary>
		private void копирайToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ChangeStrokeColorOfFigure();
		}
		private void MainForm_Load(object sender, EventArgs e) { }

		/// <summary>
		/// Method that makes the Figgure Bigger on click.
		/// </summary>
		private void уголемиToolStripMenuItem_Click(object sender, EventArgs e)
        {
		   MakeFigureBigger();
		}

		/// <summary>
		/// Method Saves the Drawing as a PNG, JPEG, JPG, BMP file.
		/// </summary>
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
			statusBar.Items[0].Text = "Последно действие: Запис на изображение";
		}

		private void pictureBox1_Click(object sender, EventArgs e) { }

		/// <summary>
		/// Method that makes the Selected Figure Bigger.
		/// </summary>
		private void MakeFigureBigger()
		{
			if (dialogProcessor.Selection != null)
			{
				dialogProcessor.Selection.Width += 30;
				dialogProcessor.Selection.Height += 30;
			}
			base.Invalidate();
		}

		/// <summary>
		/// Method that makes the Selected Figure Smaller.
		/// </summary>
		private void MakeFigureSmaller()
		{
			if (dialogProcessor.Selection != null)
			{
				dialogProcessor.Selection.Width -= 20;
				dialogProcessor.Selection.Height -= 20;
			}
			base.Invalidate();
		}

		private void намаляванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			MakeFigureSmaller();
		}

        private void случайниЦветовеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			ChangeFillColorRandomly();
			ChangeStrokeColorRandomly();
		}

        private void уголемяванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			MakeFigureBigger();
		}

        private void намаляванеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			MakeFigureSmaller();
		}

        private void изтриванеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			DeleteFigure();	
        }

        private void изтриванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DeleteFigure();
		}

        private void запишиКатоToolStripMenuItem_Click(object sender, EventArgs e)
        {
			toolStripButton7_Click(sender, e);
		}

		/// <summary>
		/// Method that saves the Drawing as a PNG file.
		/// </summary>
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

			statusBar.Items[0].Text = "Последно действие: Запис на изображение като .PNG";
		}

		/// <summary>
		/// Method that changes the Background of the Drawing Board.
		/// </summary>
		private void toolStripButton8_Click(object sender, EventArgs e)
        {

			Form something = new Form();

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp"
            };

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                base.BackgroundImage = (Image)Image.FromFile(openFileDialog.FileName).Clone();

            }

			statusBar.Items[0].Text = "Последно действие: Отвори изображение";

			base.Invalidate();
		}

        private void отвориToolStripMenuItem_Click(object sender, EventArgs e)
        {
			toolStripButton8_Click(sender, e);
		}

        private void транспарантноЗапълванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			dialogProcessor.Selection.FillColor = base.BackColor;

			base.Invalidate();
		}

        private void транспаратноЗапълванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			транспарантноЗапълванеToolStripMenuItem_Click(sender, e);
		}

		/// <summary>
		/// Method that "Rotates" the Selected Figure.
		/// </summary>
		private void завъртанеToolStripMenuItem_Click(object sender, EventArgs e)
        {

			float figureWidth = dialogProcessor.Selection.Width;
			float figureHeight = dialogProcessor.Selection.Height;

			dialogProcessor.Selection.Width = figureHeight;
			dialogProcessor.Selection.Height = figureWidth;

			statusBar.Items[0].Text = "Последно действие: Завъртане на фигура";

			base.Invalidate();
		}

        private void завъртанеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			завъртанеToolStripMenuItem_Click(sender, e);
		}

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
			запишиToolStripMenuItem_Click(sender, e);
		}

		/// <summary>
		/// Method that changes the Background Color of the Drawing Board.
		/// </summary>
		private void новToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				base.BackColor = colorDialog1.Color;
			}

			viewPort.Invalidate();

			statusBar.Items[0].Text = "Последно действие: Цвета фона беше сменен";
		}

		private void pickUpSpeedButton_Click(object sender, EventArgs e) { }

		/// <summary>
		/// Method that Copys Selected Figure Coordinates and Creates Rectangle.
		/// </summary>
		private void копиранеНаПравоъгълникToolStripMenuItem_Click(object sender, EventArgs e)
        {

			int widthOfCopiedFigure = (int)dialogProcessor.Selection.Width;
			int heightOfCopiedFigure = (int)dialogProcessor.Selection.Height;
			Color fillColorOfCopiedFigure = dialogProcessor.Selection.FillColor;
			Color strokeColorOfCopiedFigure = dialogProcessor.Selection.StrokeColor;
			string name = dialogProcessor.Selection.Name;
			string group = dialogProcessor.Selection.Group;

			dialogProcessor.CopyAndAddRectangle(widthOfCopiedFigure, heightOfCopiedFigure, fillColorOfCopiedFigure, strokeColorOfCopiedFigure, name, group);

			statusBar.Items[0].Text = "Последно действие: Копирано като правоъгълник";

			viewPort.Invalidate();

			base.Invalidate();
		}

        private void копирайПравоъгълникToolStripMenuItem_Click(object sender, EventArgs e)
        {
			копиранеНаПравоъгълникToolStripMenuItem_Click(sender, e);
		}

		/// <summary>
		/// Method that Copys Selected Figure Coordinates and Creates Circle.
		/// </summary>
		private void копиранеКатоКръгToolStripMenuItem_Click(object sender, EventArgs e)
        {
			int widthOfCopiedFigure = (int)dialogProcessor.Selection.Width;
			int heightOfCopiedFigure = (int)dialogProcessor.Selection.Height;
			Color fillColorOfCopiedFigure = dialogProcessor.Selection.FillColor;
			Color strokeColorOfCopiedFigure = dialogProcessor.Selection.StrokeColor;
			string name = dialogProcessor.Selection.Name;
			string group = dialogProcessor.Selection.Group;

			dialogProcessor.CopyAndAddCircle(widthOfCopiedFigure, heightOfCopiedFigure, fillColorOfCopiedFigure, strokeColorOfCopiedFigure, name, group);

			statusBar.Items[0].Text = "Последно действие: копирано като Кръг";

			viewPort.Invalidate();

			base.Invalidate();
		}

        private void копирайКатоКръгToolStripMenuItem_Click(object sender, EventArgs e)
        {
			копиранеКатоКръгToolStripMenuItem_Click(sender, e);
		}

		/// <summary>
		/// Method that Copys Selected Figure Coordinates and Creates Ellipse.
		/// </summary>
		private void копиранеКатоЕлипсаToolStripMenuItem_Click(object sender, EventArgs e)
        {
			int widthOfCopiedFigure = (int)dialogProcessor.Selection.Width;
			int heightOfCopiedFigure = (int)dialogProcessor.Selection.Height;
			Color fillColorOfCopiedFigure = dialogProcessor.Selection.FillColor;
			Color strokeColorOfCopiedFigure = dialogProcessor.Selection.StrokeColor;
			string name = dialogProcessor.Selection.Name;
			string group = dialogProcessor.Selection.Group;

			dialogProcessor.CopyAndAddEllipse(widthOfCopiedFigure, heightOfCopiedFigure, fillColorOfCopiedFigure, strokeColorOfCopiedFigure, name, group);

			statusBar.Items[0].Text = "Последно действие: копирано като Елипса";

			viewPort.Invalidate();

			base.Invalidate();
		}

        private void копирайКатоЕлипсаToolStripMenuItem_Click(object sender, EventArgs e)
        {
			копиранеКатоЕлипсаToolStripMenuItem_Click(sender, e);
		}

		private void toolStripTextBox1_Click(object sender, EventArgs e) { }
		/// <summary>
		/// Method that gets as input Figure Name and Color and changes that figures color by its name.
		/// </summary>
		private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
			string figureName = toolStripTextBox2.Text;

			string input = null;

			Color color = Color.White;

			input = toolStripTextBox1.Text;

			color = Color.FromName(input);

			dialogProcessor.ChangeColorByFigureName(figureName, color);

			base.Invalidate();
		}

		private void именуванеНаФигуратаToolStripMenuItem_Click(object sender, EventArgs e) { }

		/// <summary>
		/// Method that Selects a Figure by its name.
		/// </summary>
		private void избериЧрезToolStripMenuItem_Click(object sender, EventArgs e)
        {
			string input = имеНаФигураToolStripMenuItem.Text;

			if (dialogProcessor.SelectByName(input))
			{
				statusBar.Items[0].Text = "Последно действие: Селекция на примитив чрез име";

				viewPort.Invalidate();
			}
		}

		private void имеНаФигураToolStripMenuItem_Click(object sender, EventArgs e) { }

		private void toolStripButton10_Click(object sender, EventArgs e)
        {
			dialogProcessor.Save();

			base.Invalidate();

			statusBar.Items[0].Text = "Последно действие: Сериализация";
		}

		private void toolStripButton11_Click(object sender, EventArgs e) { }

        private void toolStripButton11_Click_1(object sender, EventArgs e)
        {
			dialogProcessor.Load();

			base.Invalidate();

			statusBar.Items[0].Text = "Последно действие: Десериализация";
		}

        private void правоъгълникСДиагоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
			dialogProcessor.AddRandomRectangleWithLine();

			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

			viewPort.Invalidate();

			base.Invalidate();
		}

		private void промениГрупатаToolStripMenuItem_Click(object sender, EventArgs e) { }

		/// <summary>
		/// Method that Changes the Color of a Given Group
		/// </summary>
		private void смениЦветаНаГрупаRToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				Color color = colorDialog1.Color;
				dialogProcessor.ChangeColorOfGroup(color, "A");
			}

			base.Invalidate();
		}

		/// <summary>
		/// Method that Changes the Color of a Given Group
		/// </summary>
		private void смениЦветаНаГрупаCToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				Color color = colorDialog1.Color;
				dialogProcessor.ChangeColorOfGroup(color, "B");
			}

			base.Invalidate();
		}

		private void смениЦветаНаДругаГрупаToolStripMenuItem_Click(object sender, EventArgs e) { }

		/// <summary>
		/// Method that Deletes Given Group
		/// </summary>
		private void премахниОтГрупатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
			dialogProcessor.Selection.Group = "no";
        }

		/// <summary>
		/// Method that Opens the GitHub Repostiory of the Project
		/// </summary>
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
			System.Diagnostics.Process.Start("https://github.com/erkan9/pu-computer-graphics-project");
		}

		private void завъртанеНаГрупаToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void увеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			string groupName = групаToolStripMenuItem.Text;

			dialogProcessor.MakeBiggerByGroupName(groupName);

			base.Invalidate();
		}

        private void намаляванеToolStripMenuItem2_Click(object sender, EventArgs e)
        {
			string groupName = групаToolStripMenuItem.Text;

			dialogProcessor.MakeSMallerByGroupName(groupName);

			base.Invalidate();
		}

        private void групаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			string groupName = групаToolStripMenuItem1.Text;

			dialogProcessor.DeleteGroup(groupName);

			base.Invalidate();
		}

		private void изтриванеНаГрупаToolStripMenuItem_Click(object sender, EventArgs e) { }
		/// <summary>
		/// Method that Changes Selected Figure's Group
		/// </summary>
		private void групаToolStripMenuItem2_Click(object sender, EventArgs e)
        {
			dialogProcessor.Selection.Group = групаToolStripMenuItem2.Text;

			statusBar.Items[0].Text = "Последно действие: Групата на фигурата е променена на: " + групаToolStripMenuItem2;
		}

		private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e) { }

		/// <summary>
		/// Method that Changes Selected Figure's Name
		/// </summary>
		private void имеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			string input = имеToolStripMenuItem.Text;

			dialogProcessor.Selection.Name = input;

			statusBar.Items[0].Text = "Името на фигурата бе променена на: " + input;
		}

        private void групаToolStripMenuItem3_Click(object sender, EventArgs e)
        {
			string groupName = групаToolStripMenuItem3.Text;

			dialogProcessor.RotateByGroupName(groupName);

			base.Invalidate();
		}
        private void групаToolStripMenuItem4_Click(object sender, EventArgs e)
        {
			string newGroup = групаToolStripMenuItem4.Text;

			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				Color color = colorDialog1.Color;
				dialogProcessor.ChangeColorOfNewGroup(color, newGroup);
			}
			base.Invalidate();
		}

        private void запишиМоделаToolStripMenuItem_Click(object sender, EventArgs e)
        {
			dialogProcessor.Save();

			base.Invalidate();

			statusBar.Items[0].Text = "Последно действие: Сериализация";
		}

        private void отвориМоделToolStripMenuItem_Click(object sender, EventArgs e)
        {
			dialogProcessor.Load();

			base.Invalidate();

			statusBar.Items[0].Text = "Последно действие: Десериализация";
		}
    }
}