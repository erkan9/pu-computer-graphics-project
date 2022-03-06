using System;
using System.Drawing;

namespace Draw
{
	/// <summary>
	/// Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
	/// </summary>
	[Serializable]
	public class EllipseShape : Shape
	{
		#region Constructor

		public EllipseShape(RectangleF rect) : base(rect)
		{
		}

		public EllipseShape(CircleShape rectangle) : base(rectangle)
		{
		}

		#endregion

		//Method that calls containsEllipse method that checks if "Mouse" points X, Y are inside the figure Cirche
		public override bool Contains(PointF point)
		{
			if (base.ContainsEllipse(point))

				return true;
			else
				return false;
		}



		/// <summary>
		/// Частта, визуализираща конкретния примитив.
		/// </summary>
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawEllipse(new Pen(StrokeColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

		}
	}
}
