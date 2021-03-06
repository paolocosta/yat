﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Yat
{
    public class Walk : IComparable<Walk>
    {
        List<Town> _towns;

        public Walk(List<Town> towns)
        {
            _towns = towns;
        }

        #region IComparable implementation

        public int CompareTo(Walk other)
        {
            return Length.CompareTo(other.Length);
        }

        #endregion
        
        double CalculateLength(List<Town> towns)
        {
            if (towns.Count == 0)
            {
                return 0;
            }
            return Enumerable.Range(0, towns.Count - 1).Select(i => DistanceBetween(towns[i], towns[i + 1])).Sum();
        }

        public double Length { 
            get { 
                return CalculateLength(_towns);
            } 
        }

        double DistanceBetween(Town town1, Town town2)
        {
            return Math.Sqrt(Math.Pow(town1.x - town2.x, 2) + Math.Pow(town1.y - town2.y, 2));
        }
    }
}

