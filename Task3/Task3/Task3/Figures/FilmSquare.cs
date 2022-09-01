﻿using System;
using System.Collections.Generic;
using System.Text;
using Task3.Sheets;

namespace Task3.Figures
{
    public class FilmSquare : Figure, IFilm
    {
        public FilmSquare(double side)
        {
            Side = side;
        }

        public override double Perimeter
        {
            get
            {
                return Side * 4;
            }
        }

        public double Area
        {
            get
            {
                return Side * Side;
            }
        }
    }
}
