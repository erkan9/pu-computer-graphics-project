using System;
using System.Drawing;

namespace Draw
{
	[Serializable]
	public class LineShape : Shape
	{
		#region Constructor

		public LineShape(RectangleF rect) : base(rect) { }

		public LineShape(RectangleShape rectangle) : base(rectangle) { }

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

		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			grfx.DrawLine(new Pen(StrokeColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
		}
	}
}