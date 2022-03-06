using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Draw
{
	/// <summary>
	/// Класът, който ще бъде използван при управляване на диалога.
	/// </summary>
	
	[Serializable]
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor
		
		public DialogProcessor()
		{
		}

		#endregion

		#region Properties

		Random rnd = new Random();

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

		public void Save()
		{
			string path = @"D:\temp\figures.bin";

			FileStream fileStream;
			BinaryFormatter formatter = new BinaryFormatter();	

			if(File.Exists(path)) File.Delete(path);	
			fileStream = File.Create(path);
			formatter.Serialize(fileStream, ShapeList);
			fileStream.Close();
		}

		public void Load()
        {
			string path = @"D:\temp\figures.bin";
			object obj = null;

			FileStream fileStream;

			BinaryFormatter formatter = new BinaryFormatter();

			if(File.Exists(path))
            {
				fileStream = File.OpenRead(path);

				obj = formatter.Deserialize(fileStream);
				fileStream.Close();
            }
		}

		public virtual void Show(Graphics e)
		{
			ShapeList.ForEach(x => x.DrawSelf(e));
		}


		/// <summary>
		/// Добавя примитив - правоъгълник на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomRectangle()
		{
			int x = rnd.Next(100,1000);
			int y = rnd.Next(100,600);

			RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 200))
			{
				FillColor = Color.White,

				Name = null,

                StrokeColor = Color.Black
            };

            ShapeList.Add(rect);
		}

		/// <summary>
		/// Добавя примитив - правоъгълник на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomRectangleWithLine()
		{
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			RectangleWithLineShape rectWithLine = new RectangleWithLineShape(new Rectangle(x, y, 200, 100))
			{
				FillColor = Color.White,

				Name = null,

				StrokeColor = Color.Black
			};

			ShapeList.Add(rectWithLine);
		}

		public void ChangeColorByFigureName(string figureName, Color color)
		{
			foreach (var Shape in ShapeList)
			{
				if(Shape.Name.Equals(figureName))
                {
					Shape.FillColor = color;
                }
				else
                {
					Console.WriteLine("There is not a figure with that name");
                }
			}
		}

		public void CopyAndAddRectangle(int widthOfCopiedFigure, int heightOfCopiedFigure, 
			Color fillColorOfCopiedFigure, Color strokeColorOfCopiedFigure, string name)
		{
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			RectangleShape rect = new RectangleShape(new Rectangle(x, y, widthOfCopiedFigure, heightOfCopiedFigure))
			{
				FillColor = fillColorOfCopiedFigure,

				Name = name,

				StrokeColor = strokeColorOfCopiedFigure
			};

			ShapeList.Add(rect);
		}

		public void CopyAndAddCircle(int widthOfCopiedFigure, int heightOfCopiedFigure,
			Color fillColorOfCopiedFigure, Color strokeColorOfCopiedFigure, string name)
		{
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, widthOfCopiedFigure, heightOfCopiedFigure))
			{
				FillColor = fillColorOfCopiedFigure,

				Name = name,

				StrokeColor = strokeColorOfCopiedFigure
			};

			ShapeList.Add(ellipse);
		}

		public void CopyAndAddEllipse(int widthOfCopiedFigure, int heightOfCopiedFigure,
			Color fillColorOfCopiedFigure, Color strokeColorOfCopiedFigure, string name)
		{
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			CircleShape circ = new CircleShape(new Rectangle(x, y, widthOfCopiedFigure, heightOfCopiedFigure))
			{
				FillColor = fillColorOfCopiedFigure,

				Name = name,

				StrokeColor = strokeColorOfCopiedFigure
			};

			ShapeList.Add(circ);
		}

		public bool SelectByName(string figureName)
        {
			foreach (Shape shape in ShapeList)
            {
				if (shape.Name == figureName)
                {
					return true;
				}
            }
			return false;
        }

		/// <summary>
		/// Добавя примитив - Кръг на произволно място върху клиентската област.
		/// </summary>
		public void AddCircle()
		{

            CircleShape circle = new CircleShape(new Rectangle(680, 300, 100, 100))
            {
                FillColor = Color.White,

				Name = null,

				StrokeColor = Color.Black
            };

            ShapeList.Add(circle);
		}

		/// <summary>
		/// Добавя примитив - Елипса на произволно място върху клиентската област.
		/// </summary>
		public void AddEllipse()
		{

            EllipseShape ellipse = new EllipseShape(new Rectangle(680, 200, 145, 175))
            {
                FillColor = Color.White,

				Name = null,

				StrokeColor = Color.Black
            };

            ShapeList.Add(ellipse);
		}

		/// <summary>
		/// Добавя примитив - Елипса на произволно място върху клиентската област.
		/// </summary>
		public void AddLine()
		{

            int x = rnd.Next(200, 1000);
			int y = rnd.Next(160, 600);

			int x2 = rnd.Next(250, 1000);
			int y2 = rnd.Next(200, 600);

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
