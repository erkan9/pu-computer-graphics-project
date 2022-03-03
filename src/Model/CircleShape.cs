﻿using System;
using System.Drawing;

namespace Draw
{
	/// <summary>
	/// Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
	/// </summary>
	public class CircleShape : Shape
	{
		#region Constructor

		public CircleShape(RectangleF rect) : base(rect)
		{
		}

		public CircleShape(CircleShape rectangle) : base(rectangle)
		{
		}

		#endregion

	

		//Method that calls ContainsCircle method that checks if "Mouse" points X, Y are inside the figure Cirche
		public override bool Contains(PointF point)
		{
			if (base.ContainsCircle(point))
				
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