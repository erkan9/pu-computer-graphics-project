using System;
using System.Drawing;

namespace Draw
{

	[Serializable]
	public class RectangleShape : Shape
	{
		#region Constructor
		
		public RectangleShape(RectangleF rect) : base(rect) { }
		
		public RectangleShape(RectangleShape rectangle) : base(rectangle) { }

		#endregion

		/// <summary>
		/// Method that checks if the Point is inside the figure.
		/// </summary>
		public override bool Contains(PointF point)
		{
			if (base.Contains(point))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Method that Draws the Figure.
		/// </summary>
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			grfx.FillRectangle(new SolidBrush(FillColor),Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawRectangle(new Pen(StrokeColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
		}
	}
}