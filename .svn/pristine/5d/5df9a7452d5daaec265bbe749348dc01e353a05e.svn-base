using System;
using System.Drawing;

namespace Draw
{

	[Serializable]
	public class CircleShape : Shape
	{
		#region Constructor

		public CircleShape(RectangleF rect) : base(rect) {}

		public CircleShape(CircleShape rectangle) : base(rectangle) {}

		#endregion

		/// <summary>
		/// Method that checks if the Clicked location as X, Y is in the Circle.
		/// </summary>
		public virtual bool ContainsCircle(PointF point)
		{
			int offSet = 50;

			bool isInsideFigureCalculator = ((point.X - offSet) - Rectangle.X) * ((point.X - offSet) - Rectangle.X) + ((point.Y - offSet) -
				Rectangle.Y) * ((point.Y - offSet) - Rectangle.Y) <= 50 * 50;

			if (isInsideFigureCalculator)
			{
				Console.WriteLine("The cursor is inside the Figure");

				return true;
			}
			else
			{
				Console.WriteLine("The cursor is NOT inside the Figure");

				return false;
			}
		}

		/// <summary>
		/// Method that Draws the Figure.
		/// </summary>
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawEllipse(new Pen(StrokeColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
		}
	}
}