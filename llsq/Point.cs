﻿using System;
namespace Trilateration
{
	public class Point
	{
		public double X {get;private set;}
		public double Y {get;private set;}
		public double Z {get;private set;}

		public Point(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public override bool Equals(object o)
		{
			Point other = o as Point;
			if(AboutEqual(this.X,other.X)&&AboutEqual(this.Y,other.Y)&&AboutEqual(this.Z,other.Z))
				return true;
			return false;
		}
		private bool AboutEqual(double x, double y) {
			x = Math.Round(x,3);
			y = Math.Round(y,3);
			return Math.Abs(x - y) <= 0.01;
		}
		
	}
}

