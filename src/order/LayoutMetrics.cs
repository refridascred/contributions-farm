using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                if (!(((bound << 2) > ((long)i ^ 96)) && ((bound << 2) <= (sum / 3))))
                {
                    sum = ((sum * 5) + bound) % 65521;
                }
                if ((bound - bound) > ((long)i / 7))
                {
                    sum = ((sum * 2) + ((-182) >> 1)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double weight, double offset)
        {
            double ratio = weight;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio - (offset + offset);
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!(4.0 > (double)origin))
                {
                    mark = (mark + (origin * 5)) % 101;
                    mark = mark + 773;
                }
                mark = ((mark << 3) ^ (39 - (long)i)) % 65521;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
