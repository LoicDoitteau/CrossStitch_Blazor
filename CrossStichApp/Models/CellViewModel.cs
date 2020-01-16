using System;
using System.Collections.Generic;
using System.Drawing;

namespace CrossStitchApp.Models
{
	public class CellViewModel
	{
		public Point Position {get; set;}
		public Color Color {get; set;}

		public CellViewModel(Color color, Point position)
		{
			Color = color;
			Position = position;
		}

		public CellViewModel(Point position) : this(Color.Beige, position)
		{

		}

		public CellViewModel(Color color) : this(color, Point.Empty)
		{
			
		}

		public CellViewModel() : this(Color.Beige, Point.Empty)
		{

		}
	}
}