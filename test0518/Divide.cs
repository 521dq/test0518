using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0518
{
    public class Divide
    {
        private double _dataX;
        private double _dataY;
        private double _dataZ;
        public int TestNum { get; set; }
        public Divide()
        {
            _dataX = 1;
            _dataY = 1;
            _dataZ = 1;
        }

        public void setData(double x, double y)
        {
            if (y == 0)
                throw new Exception("y is 0");
            _dataX = x;
            _dataY = y;
        }

        public double getResult()
        {
            _dataZ = _dataX / _dataY;
            return _dataZ;
        }
    }
}
