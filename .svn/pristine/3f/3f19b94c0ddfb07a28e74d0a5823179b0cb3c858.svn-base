using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Draw
{
	/// <summary>
	/// Class that is used to control the Display System
	/// </summary>
	public class DisplayProcessor
	{
		#region Constructor
		
		public DisplayProcessor() { }

		#endregion

		#region Properties

		/// <summary>
		/// List of all the Shapes that create an Image/Picture/Drawing
		/// </summary>
		private List<Shape> shapeList = new List<Shape>();		
		public List<Shape> ShapeList {
			get { return shapeList; }
			set { shapeList = value; }
		}

		#endregion

		#region Drawing

		/// <summary>
		/// Method that draws all the Shapes in ShapeList over the e.Graphics
		/// </summary>
		public void ReDraw(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Draw(e.Graphics);
		}
		
		/// <summary>
		/// Method that Loads all the Shapes in the ShapeList and calls their Draw method
		/// </summary>
		/// <param name="grfx">Where the visualisations are done</param>
		public virtual void Draw(Graphics grfx)
		{
			foreach (Shape item in ShapeList)
			{
				DrawShape(grfx, item);
			}
		}

		/// <summary>
		/// Method that visualises a specific element.
		/// </summary>
		/// <param name="grfx">Where the visualisations are done.</param>
		/// <param name="item">The element/Shape for visualisation.</param>
		public virtual void DrawShape(Graphics grfx, Shape item)
		{
			item.DrawSelf(grfx);
		}

		#endregion
	}
}
