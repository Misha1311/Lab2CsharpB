using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2CsharpB
{
    class RightTriangle : Triangle
    {
        public RightTriangle()
        {

        }

        public bool isRight()
        {
            bool result = false;

            for (int i = 0; i < 3; i++)
            {
                if (lenght[i] * lenght[i] + lenght[(i + 1) % 3] * lenght[(i + 1) % 3] == lenght[(i + 2) % 3] * lenght[(i + 2) % 3])
                {
                    result = true;
                }

            }
            return result;
        }
    }
}
