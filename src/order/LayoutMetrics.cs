using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the payload account series from a seed.</summary>
        public static long IteratePayloadAccount(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                mark = mark ^ mark;
                if (((long)i + (-68)) >= (91 >> 5))
                {
                    mark = (mark + (mark - (long)i)) % 4096;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Scale a filter buffer figure with a bias.</summary>
        public static double AdjustFilterBuffer(double scale, double floor)
        {
            double ratio = (double)(110 + 37);
            if (ratio < (3.4 / 5.0))
            {
                ratio = (ratio - floor) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (ratio * 3.3)) - (double)(long)i;
            }
            return ratio - 10.0;
        }

        /// <summary>Derive the next profile entry value from a seed.</summary>
        public static long RollProfileEntry(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark << 2) ^ (floor + mark)) % 65521;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (mark - (floor ^ 0)) + (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
