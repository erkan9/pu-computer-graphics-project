using System;
using System.Drawing;

namespace Draw
{
    /// <summary>
    /// Base class of the Figures, which contains characteristics of the figures.
    /// </summary>
    [Serializable]
	public abstract class Shape
	{
		#region Constructors

		public Shape() {}
		
		public Shape(RectangleF rect)
		{
			rectangle = rect;
		}
		
		public Shape(Shape shape)
		{
			this.Height = shape.Height;
			this.Width = shape.Width;
			this.Location = shape.Location;
			this.rectangle = shape.rectangle;

			this.Name = shape.Name;

			this.Group = shape.Group;

			this.FillColor =  shape.FillColor;
		}
        #endregion

        #region Properties

        /// <summary>
        /// Enclosing rectangle of the element.
        /// </summary>
        private RectangleF rectangle;

        public virtual string Name { get; set; }

		public virtual string Group { get; set; }

		public virtual RectangleF Rectangle
		{
			get { return rectangle; }
			set { rectangle = value; }
		}
		
		/// <summary>
		/// Width of Shapes.
		/// </summary>
		public virtual float Width
		{
			get { return Rectangle.Width; }
			set { rectangle.Width = value; }
		}

		/// <summary>
		/// Height of Shapes.
		/// </summary>
		public virtual float Height
		{
			get { return Rectangle.Height; }
			set { rectangle.Height = value; }
		}

		/// <summary>
		/// Top Left edge of the figure.
		/// </summary>
		public virtual PointF Location 
		{
			get { return Rectangle.Location; }
			set { rectangle.Location = value; }
		}
		
		/// <summary>
		/// Fill Color of the figure.
		/// </summary>
		private Color fillColor;		
		public virtual Color FillColor 
		{
			get { return fillColor; }
			set { fillColor = value; }
		}

		/// <summary>
		/// Stroke Color of the figure.
		/// </summary>
		private Color strokeColor;
		public virtual Color StrokeColor
		{
			get { return strokeColor; }
			set { strokeColor = value; }
		}

		#endregion


		/// <summary>
		/// Check if the points Poins inside the element
		/// </summary>
		/// <param name="point">THe Points</param>
		/// <returns>Returns True if it is in the element or
		/// false, if it does not</returns>
		public virtual bool Contains(PointF point)
		{

			return Rectangle.Contains(point.X, point.Y);
		}

        /// <summary>
        /// Visualise the Element.
        /// </summary>
        /// <param name="grfx">The place where the figure is going to be visualised.</param>
        public virtual void DrawSelf(Graphics grfx)
		{
			// shape.Rectangle.Inflate(shape.BorderWidth, shape.BorderWidth);
		}
	}
}
