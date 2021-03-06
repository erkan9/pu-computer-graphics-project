using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Draw
{
	/// <summary>
	/// The class that is used for controling the dialog.
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

        private readonly Random rnd = new Random();
        private FileStream fileStream;
		private readonly BinaryFormatter formatter = new BinaryFormatter();

        private readonly string path = @"D:\temp\figures.bin";

		private readonly string rectangleShapesGroupe = "A";

		private readonly string rectangleShapesGroupeB = "B";

		private readonly Color defaultFillColor = Color.White;

		private readonly Color defaultStrokeColor = Color.Black;

		/// <summary>
		/// The Chosen Element.
		/// </summary>
		private Shape selection;
		public Shape Selection {
			get { return selection; }
			set { selection = value; }
		}
		
		/// <summary>
		/// Checks if currently the dialog is in form of "Draging" the chosen Element/Shape.
		/// </summary>
		private bool isDragging;
		public bool IsDragging {
			get { return isDragging; }
			set { isDragging = value; }
		}
		
		/// <summary>
		/// The last position of the Cursor while in form if "Draging"
		/// </summary>
		private PointF lastLocation;
		public PointF LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}
		#endregion

		/// <summary>
		/// Method that Serializes and used to save the Drawing as a .bin file in a specific path.
		/// </summary>
		public void Save()
		{
			
			if (File.Exists(this.path))
			{
				File.Delete(this.path);
			}

            this.fileStream = File.Create(this.path);

			this.formatter.Serialize(fileStream, ShapeList);

			this.fileStream.Close();
		}

		/// <summary>
		/// Method that Deserialize and used for Loading the Last drawing, which is saved as a .bin file.
		/// </summary>
		public void Load()
        {
			object obj = null;

			if(File.Exists(this.path))
            {
				this.fileStream = File.OpenRead(this.path);

				obj = this.formatter.Deserialize(this.fileStream);

				var res = (List<Shape>)obj;

				res.ForEach(s => ShapeList.Add(s));

				this.fileStream.Close();
            }
		}

		/// <summary>
		/// Method that Creates and Draws a Rectangle Figure in a random location.
		/// </summary>
		public void AddRandomRectangle()
		{
			int x = rnd.Next(100,1000);
			int y = rnd.Next(100,600);

			RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 200))
			{
				FillColor = defaultFillColor,

				Name = "Rectangle",

				Group = rectangleShapesGroupe,

                StrokeColor = defaultStrokeColor
			};

            ShapeList.Add(rect);
		}

		/// <summary>
		/// Method that Creates and Draws a Rectangle Figure with 1 Diagonal in a random location.
		/// </summary>
		public void AddRandomRectangleWithLine()
		{
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			RectangleWithLineShape rectWithLine = new RectangleWithLineShape(new Rectangle(x, y, 200, 100))
			{
				FillColor = defaultFillColor,

				Name = "Rectangle",

				Group = rectangleShapesGroupe,

				StrokeColor = defaultStrokeColor
			};

			ShapeList.Add(rectWithLine);
		}


		/// <summary>
		/// Method that Creates and Draws a Circle in a specific location.
		/// </summary>
		public void AddCircle()
		{

			CircleShape circle = new CircleShape(new Rectangle(680, 300, 100, 100))
			{
				FillColor = defaultFillColor,

				Name = "Circle",

				Group = rectangleShapesGroupeB,

				StrokeColor = defaultStrokeColor
			};

			ShapeList.Add(circle);
		}

		/// <summary>
		/// Method that Creates and Draws a Ellipse in a specific location.
		/// </summary>
		public void AddEllipse()
		{

			EllipseShape ellipse = new EllipseShape(new Rectangle(680, 200, 145, 175))
			{
				FillColor = defaultFillColor,

				Name = "Ellipse",

				Group = rectangleShapesGroupeB,

				StrokeColor = defaultStrokeColor
			};

			ShapeList.Add(ellipse);
		}

		/// Method that Creates and Draws a Line in a Random Location.
		public void AddLine()
		{

			int x = rnd.Next(200, 1000);
			int y = rnd.Next(160, 600);

			int x2 = rnd.Next(250, 1000);
			int y2 = rnd.Next(200, 600);

			LineShape line = new LineShape(new Rectangle(x, y, x2, y2))
			{
				FillColor = defaultFillColor,

				Name = "Line",

				Group = rectangleShapesGroupeB,

				StrokeColor = defaultStrokeColor
			};

			ShapeList.Add(line);
		}

		/// <summary>
		/// Method that Find a feagure by its name and changes its color.
		/// </summary>
		public void ChangeColorByFigureName(string figureName, Color color)
		{
			foreach (var Shape in ShapeList)
			{
				if(Shape.Name.Equals(figureName))
                {
					Shape.FillColor = color;
                }
			}
		}

		/// <summary>
		/// Method that Copys and creates the chosen Figure as a Rectangle.
		/// </summary>
		public void CopyAndAddRectangle(int widthOfCopiedFigure, int heightOfCopiedFigure, 
			Color fillColorOfCopiedFigure, Color strokeColorOfCopiedFigure, string name, string group)
		{
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			RectangleShape rect = new RectangleShape(new Rectangle(x, y, widthOfCopiedFigure, heightOfCopiedFigure))
			{
				FillColor = fillColorOfCopiedFigure,

				Name = name,

				Group = group,

				StrokeColor = strokeColorOfCopiedFigure
			};

			ShapeList.Add(rect);
		}

		/// <summary>
		/// Method that Copys and creates the chosen Figure as a Circle.
		/// </summary>
		public void CopyAndAddCircle(int widthOfCopiedFigure, int heightOfCopiedFigure,
			Color fillColorOfCopiedFigure, Color strokeColorOfCopiedFigure, string name, string group)
		{
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, widthOfCopiedFigure, heightOfCopiedFigure))
			{
				FillColor = fillColorOfCopiedFigure,

				Name = name,

				Group = group,

				StrokeColor = strokeColorOfCopiedFigure
			};

			ShapeList.Add(ellipse);
		}

		/// <summary>
		/// Method that Copys and creates the chosen Figure as a Ellipse.
		/// </summary>
		public void CopyAndAddEllipse(int widthOfCopiedFigure, int heightOfCopiedFigure,
			Color fillColorOfCopiedFigure, Color strokeColorOfCopiedFigure, string name, string group)
		{
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			CircleShape circ = new CircleShape(new Rectangle(x, y, widthOfCopiedFigure, heightOfCopiedFigure))
			{
				FillColor = fillColorOfCopiedFigure,

				Name = name,

				Group = group,

				StrokeColor = strokeColorOfCopiedFigure
			};

			ShapeList.Add(circ);
		}

		/// <summary>
		/// Method that changes given group's figure's color.
		/// </summary>
		public void ChangeColorOfGroup(Color color, string groupName)
		{
			foreach (Shape shape in ShapeList)
			{
				if (shape.Group.Equals(groupName))
				{
					shape.FillColor = color;
				}
			}
		}

		/// <summary>
		/// Method that Finds a new Created group and changes its color.
		/// </summary>
		public void ChangeColorOfNewGroup(Color color, string newGroup)
		{
			foreach (Shape shape in ShapeList)
			{
				if (shape.Group.Equals(newGroup))
				{
					shape.FillColor = color;
				}
			}
		}

		/// <summary>
		/// Method that selects a figure by its name.
		/// </summary>
		public bool SelectByName(string figureName)
        {
			foreach (Shape shape in ShapeList)
            {
				if (shape.Name.Equals(figureName))
                {
					return true;
				}
            }
			return false;
        }

		/// <summary>
		/// Method Deletes a given Group Name.
		/// </summary>
		public void DeleteGroup(string groupName)
		{
			foreach (Shape shape in ShapeList)
			{
				if (shape.Group.Equals(groupName))
				{
					shape.Group = "no";
				}
			}
		}

		/// <summary>
		/// Make Bigger.
		/// Method that makes Size changes of all the figures in a given Group by name.
		/// </summary>
		public void MakeBiggerByGroupName(string groupName)
		{
			foreach (Shape shape in ShapeList)
			{
				if (shape.Group.Equals(groupName))
				{
					shape.Width += 50;
					shape.Height += 50;
				}
			}
		}

		/// <summary>
		/// Make Smaller.
		/// Method that makes Size changes of all the figures in a given Group by name.
		/// </summary>
		public void MakeSMallerByGroupName(string groupName)
		{
			foreach (Shape shape in ShapeList)
			{
				if (shape.Group.Equals(groupName))
				{
					shape.Width -= 50;
					shape.Height -= 50;
				}
			}
		}

		/// <summary>
		/// Method that Rotates all the figures in a given Group by name.
		/// </summary>
		public void RotateByGroupName(string groupName)
        {
			foreach (Shape shape in ShapeList)
			{
				if (shape.Group.Equals(groupName))
				{
					float figureWidth = shape.Width;
					float figureHeight = shape.Height;

					shape.Width = figureHeight;
					shape.Height = figureWidth;
				}
			}
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
		/// Translation of the chosen Figure of Vector decided from <paramref name="points>p</paramref>
		/// </summary>
		/// <param name="points">Vector of Translation.</param>
		public void TranslateTo(PointF points)
		{
			if (selection != null) {

				selection.Location = new PointF(selection.Location.X + points.X - lastLocation.X, selection.Location.Y + points.Y - lastLocation.Y);

				lastLocation = points;
			}
		}
	}
}
