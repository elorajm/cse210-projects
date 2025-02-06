using System;
 public class Fractions
    {
        private int _top;
        private int _bottom;

        public Fractions()
        {
            _bottom = 1;
            _top = 1;
        }

        public Fractions(int number)
        {
            _top = number;
            _bottom = 1;

        }

        public Fractions(int top, int bottom)
        {
            _top = top;
            _bottom= bottom;
        }

        public void SetTopValue(int topNumber)
        {
            _top = topNumber;
        }

        public void SetBottomValue(int bottomNumber)
        {
            _bottom = bottomNumber;
        }

        public int GetTopNumber()
        {
            return _top;
        }

        public int GetBottomNumber()
        {
            return _bottom;
        }

        public string GetFractionString()
        {
            return $"{_top}/{_bottom}";
        }
        public double GetDecimalValue()
        {
            return (double)_top/(double)_bottom;
        }
    }