 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Q7
{
    internal class Ball
    {
        private int size;
        private Color color;
        private int numberOfThrown;

        public Ball(int size, Color color, int numberOfThrown)
        {
            this.size = size;
            this.color = color;
            this.numberOfThrown = numberOfThrown;
        }
        public Ball(int size, int red, int green, int blue, int numberOfThrown)
        {
            this.size = size;
            this.color = new Color(red, green, blue);
            this.numberOfThrown = numberOfThrown;
        }

        public void Pop()
        {
            this.size = 0;
        }

        public void Throw()
        {
            if(this.size > 0)
            {
                numberOfThrown++;
            }
            else
            {
                throw new Exception("Can't throw because the size of ball is less than 1.");
            }
        }
        public int getNumberOfThrown()
        {
            return numberOfThrown;
        }
    }
}
