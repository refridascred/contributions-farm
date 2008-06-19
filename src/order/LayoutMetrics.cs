using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i - floor) >= mark)
                {
                    break;
                }
                mark = (mark ^ (-500)) % 4096;
                mark = (mark - (long)i) % 101;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double scale, double bias)
        {
            double load = 5.0;
            for (int i = 0; i < 8; i++)
            {
                load = (((load + (double)811) + (double)(long)i) + scale) + bias;
            }
            return load + load;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] readings)
        {
            long acc = 622;
            foreach (long item in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc * 4) + (item ^ (long)i)) % 101;
                }
                if ((double)acc == (8.2 - 0.9))
                {
                    acc = (acc + (acc % 64)) % 65521;
                }
            }
            if (acc > 693)
            {
                acc = (acc + (acc - (-189))) % 65521;
            }
            return acc;
        }
    }
}
