using SuperClicker.Core.Click_Location_Strategies;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace SuperClicker
{
    internal class SelectionClickLocationStrategy : IClickLocationStrategy
    {
        private List<Point> _clickPoints = new List<Point>();
        private int _nextPointIndex = 0;

        public SelectionClickLocationStrategy(IEnumerable<Point> clickPoints)
        {
            if (clickPoints == null)
            {
                throw new ArgumentNullException($"{nameof(_clickPoints)} cannot be null.");
            }
            
            _clickPoints = new List<Point>(clickPoints);

            //Enumerable doesn't have count or length property, check that output has values 
            if (_clickPoints.Count == 0)
            {
                throw new ArgumentException($"Must supply at least one click point");
            }
        }

        public Point GetClickLocation()
        {
            if (_nextPointIndex >= _clickPoints.Count)
            {
                _nextPointIndex = 0;
            }

            return _clickPoints[_nextPointIndex++];
        }
    }
}