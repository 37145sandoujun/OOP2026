using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    internal class InchConverter
    {
        private static readonly double ratio = 0.0254;//定数

        //メートルからインチを求める
        public static double Tometle(double meter)
        {
            return meter / ratio;
        }
    }
}
