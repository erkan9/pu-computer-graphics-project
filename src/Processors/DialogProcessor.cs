using System;
using System.Drawing;

namespace Draw
{
	/// <summary>
	/// Класът, който ще бъде използван при управляване на диалога.
	/// </summary>
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor
		
		public DialogProcessor()
		{
		}
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Избран елемент.
		/// </summary>
		private Shape selection;
		public Shape Selection {
			get { return selection; }
			set { selection = value; }
		}
		
		/// <summary>
		/// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
		/// </summary>
		private bool isDragging;
		public bool IsDragging {
			get { return isDragging; }
			set { isDragging = value; }
		}
		
		/// <summary>
		/// Последна позиция на мишката при "влачене".
		/// Използва се за определяне на вектора на транслация.
		/// </summary>
		private PointF lastLocation;
		public PointF LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}
		
		#endregion
		
		/// <summary>
		/// Добавя примитив - правоъгълник на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomRectangle()
		{
			Random rnd = new Random();

			int x = rnd.Next(100,1000);
			int y = rnd.Next(100,600);
			
			RectangleShape rect = new RectangleShape(new Rectangle(x,y,100,200));

			rect.FillColor = Color.White;

			rect.StrokeColor = Color.Black;

			ShapeList.Add(rect);
		}

		/// <summary>
		/// Добавя примитив - Елипса на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomCircle()
		{
		
			CircleShape circle = new CircleShape(new Rectangle(680, 300, 100, 100));

			circle.FillColor = Color.White;

			circle.StrokeColor = Color.Black;
		
			ShapeList.Add(circle);
		}

		/// <summary>
		/// Добавя примитив - Елипса на произволно място върху клиентската област.
		/// </summary>
		public void addLine()
		{
			Random randomNumber = new Random();

			int x = randomNumber.Next(200, 1000);
			int y = randomNumber.Next(160, 600);

			int x2 = randomNumber.Next(250, 1000);
			int y2 = randomNumber.Next(200, 600);

			LineShape line = new LineShape(new Rectangle(x, y,  x2, y2));

			line.FillColor = Color.White;

			line.StrokeColor = Color.Black;

			ShapeList.Add(line);
		}

		/// <summary>
		/// Проверява дали дадена точка е в елемента.
		/// Обхожда в ред обратен на визуализацията с цел намиране на
		/// "най-горния" елемент т.е. този който виждаме под мишката.
		/// </summary>
		/// <param name="point">Указана точка</param>
		/// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
		public Shape ContainsPoint(PointF point)
		{
			for(int counter = ShapeList.Count - 1; counter >= 0; counter--){

				if (ShapeList[counter].Contains(point)){

						
					return ShapeList[counter];
				}	
			}
			return null;
		}
		
		/// <summary>
		/// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
		/// </summary>
		/// <param name="p">Вектор на транслация.</param>
		public void TranslateTo(PointF p)
		{
			if (selection != null) {
				selection.Location = new PointF(selection.Location.X + p.X - lastLocation.X, selection.Location.Y + p.Y - lastLocation.Y);
				lastLocation = p;
			}
		}
	}
}
