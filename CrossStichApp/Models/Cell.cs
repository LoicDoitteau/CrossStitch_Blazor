using System;
using System.Collections.Generic;
using System.Drawing;

namespace CrossStitchApp.Models
{
	public class Cell
	{
		public Point Position {get; set;}
		public Color Color {get; set;}

		public Cell(Color color, Point position)
		{
			Color = color;
			Position = position;
		}

		public Cell(Point position) : this(Color.Beige, position)
		{

		}

		public Cell(Color color) : this(color, Point.Empty)
		{
			
		}

		public Cell() : this(Color.Beige, Point.Empty)
		{

		}
	}
}