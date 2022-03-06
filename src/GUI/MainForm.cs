using System;
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

		System.Windows.Forms.MouseEventArgs e;
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

			base.Refresh();
		}

		private void ChangeFillColorOfFigure(object sender, EventArgs e)
        {
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				dialogProcessor.Selection.FillColor = colorDialog1.Color;

				statusBar.Items[0].Text = "Последно действие: Цвета на фигурата е сменена";

				viewPort.Invalidate();
			}
			base.Refresh();
		}

		private void ChangeStrokeColorOfFigure(object sender, EventArgs e)
        {
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				dialogProcessor.Selection.StrokeColor = colorDialog1.Color;

				statusBar.Items[0].Text = "Последно действие: Цвета на лиините на фигурата е сменена";

				viewPort.Invalidate();
			}
			base.Refresh();
		}

		private void ChangeFillColorRandomly()
        {
			Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

			statusBar.Items[0].Text = "Последно действие: Цвета на фигурата е сменена случайно";

			dialogProcessor.Selection.FillColor = randomColor;

			base.Refresh();
		}

		private void ChangeStrokeColorRandomly()
		{
			Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));


			statusBar.Items[0].Text = "Последно действие: Цвета на лиините на фигурата е случайно";

			dialogProcessor.Selection.StrokeColor = randomColor;

			base.Refresh();
		}

		public void DeleteFigure()
		{

			dialogProcessor.ShapeList.Remove(dialogProcessor.Selection);

			base.Refresh();
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
		   MakeFigureBigger();
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
			statusBar.Items[0].Text = "Последно действие: Запис на изображение";
		}

		private void pictureBox1_Click(object sender, EventArgs e)
        {
			
        }

		private void MakeFigureBigger()
		{
			if (dialogProcessor.Selection != null)
			{
				dialogProcessor.Selection.Width += 30;
				dialogProcessor.Selection.Height += 30;
			}
			base.Refresh();
		}

		private void MakeFigureSmaller()
		{
			if (dialogProcessor.Selection != null)
			{
				dialogProcessor.Selection.Width -= 20;
				dialogProcessor.Selection.Height -= 20;
			}
			base.Refresh();
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

		//Method that Reads and opens a file and uses it as a background
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

			statusBar.Items[0].Text = "Последно действие: Отвори/Прочети изображение";

			base.Refresh();
		}


        private void отвориToolStripMenuItem_Click(object sender, EventArgs e)
        {
			toolStripButton8_Click(sender, e);
		}

        private void транспарантноЗапълванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			dialogProcessor.Selection.FillColor = base.BackColor;

			base.Refresh();
		}

        private void транспаратноЗапълванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
			транспарантноЗапълванеToolStripMenuItem_Click(sender, e);
		}

        private void завъртанеToolStripMenuItem_Click(object sender, EventArgs e)
        {

			float figureWidth = dialogProcessor.Selection.Width;
			float figureHeight = dialogProcessor.Selection.Height;

			dialogProcessor.Selection.Width = figureHeight;
			dialogProcessor.Selection.Height = figureWidth;

			statusBar.Items[0].Text = "Последно действие: Завъртане на фигура";

			base.Refresh();
		}

        private void завъртанеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			завъртанеToolStripMenuItem_Click(sender, e);

		}

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
			запишиToolStripMenuItem_Click(sender, e);

		}

        private void новToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				base.BackColor = colorDialog1.Color;

				viewPort.Invalidate();
			}
			statusBar.Items[0].Text = "Последно действие: Цвета фона беше сменен";
		}

        private void pickUpSpeedButton_Click(object sender, EventArgs e)
        {

        }

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

			base.Refresh();
		}

        private void копирайПравоъгълникToolStripMenuItem_Click(object sender, EventArgs e)
        {
			копиранеНаПравоъгълникToolStripMenuItem_Click(sender, e);

		}


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

			base.Refresh();
		}

        private void копирайКатоКръгToolStripMenuItem_Click(object sender, EventArgs e)
        {
			копиранеКатоКръгToolStripMenuItem_Click(sender, e);
		}

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

			base.Refresh();
		}

        private void копирайКатоЕлипсаToolStripMenuItem_Click(object sender, EventArgs e)
        {
			копиранеКатоЕлипсаToolStripMenuItem_Click(sender, e);

		}

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
		
		}

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
			string figureName = toolStripTextBox2.Text;

			string input = null;

			Color color = Color.White;

			input = toolStripTextBox1.Text;

			color = Color.FromName(input);

			dialogProcessor.ChangeColorByFigureName(figureName, color);

			base.Refresh();
		}

        private void именуванеНаФигуратаToolStripMenuItem_Click(object sender, EventArgs e)
        {
			string input = именуванеНаФигуратаToolStripMenuItem.Text;

			dialogProcessor.Selection.Name = input;

			statusBar.Items[0].Text = "Името на фигурата бе променена на: " + input;

		}

        private void избериЧрезToolStripMenuItem_Click(object sender, EventArgs e)
        {
			string input = имеНаФигураToolStripMenuItem.Text;

			if (dialogProcessor.SelectByName(input))
			{
				statusBar.Items[0].Text = "Последно действие: Селекция на примитив чрез име";

				viewPort.Invalidate();
			}
		}

        private void имеНаФигураToolStripMenuItem_Click(object sender, EventArgs e)
		{ 

		}
		

		private void toolStripButton10_Click(object sender, EventArgs e)
        {
			dialogProcessor.Save();
			base.Invalidate();
			statusBar.Items[0].Text = "Последно действие: Сериализация";
		}

        private void toolStripButton11_Click(object sender, EventArgs e)
        {

	
		}

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

			base.Refresh();
		}

        private void промениГрупатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
			dialogProcessor.Selection.Group = промениГрупатаToolStripMenuItem.Text;

			statusBar.Items[0].Text = "Последно действие: Групата на фигурата е променена на: " + промениГрупатаToolStripMenuItem.Text;
		}

        private void смениЦветаНаГрупаRToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				Color color = colorDialog1.Color;
				dialogProcessor.ChangeColorOfGroupA(color);
			}

			base.Invalidate();
		}

        private void смениЦветаНаГрупаCToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				Color color = colorDialog1.Color;
				dialogProcessor.ChangeColorOfGroupB(color);
			}

			base.Invalidate();
		}

        private void смениЦветаНаДругаГрупаToolStripMenuItem_Click(object sender, EventArgs e)
        {
			string newGroup = смениЦветаНаДругаГрупаToolStripMenuItem.Text;

			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				Color color = colorDialog1.Color;
				dialogProcessor.ChangeColorOfNewGroup(color, newGroup);
			}
			base.Invalidate();
		}

        private void премахниОтГрупатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
			dialogProcessor.Selection.Group = " ";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
			System.Diagnostics.Process.Start("https://github.com/erkan9/pu-computer-graphics-project");
		}

        private void завъртанеНаГрупаToolStripMenuItem_Click(object sender, EventArgs e)
        {

			string groupName = завъртанеНаГрупаToolStripMenuItem.Text;

			dialogProcessor.RotateByGroupName(groupName);

			base.Invalidate();
		}

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
    }
}