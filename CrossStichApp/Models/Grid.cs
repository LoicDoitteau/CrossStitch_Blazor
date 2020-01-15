using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace CrossStitchApp.Models
{
	public class Grid
	{
		public int Cols {get;}
		public int Rows {get;}
		public IEnumerable<Cell> Cells {get;}

		public Grid(int cols, int rows)
		{
			Cols = cols;
			Rows = rows;
			Cells = Enumerable.Range(0, cols * rows).Select(i => new Cell(new Point(i % cols, (int)Math.Floor((float)i / cols))));
		}
	}
}