using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.BL
{
    class Point
    {
        public int x;
        public int y;
        public Point()
        {

        }
        public Point(int x,int y)
        {
            this.x=x;
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void setXY(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
