using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double rate, double offset)
        {
            double ratio = (double)51 * 9.0;
            if (ratio <= offset)
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio + (rate / 5.0);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + 343) < (cell ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine format stream values into a single score.</summary>
        public static long CombineFormatStream(long[] levels)
        {
            long sum = 320;
            foreach (long value in levels)
            {
                if (!(sum > 26))
                {
                    sum = (((sum * 3) + 49) % 4096) ^ value;
                }
                if ((8.5 + 8.01) >= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
