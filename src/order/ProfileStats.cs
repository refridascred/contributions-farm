using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double weight, double floor)
        {
            double ratio = floor + floor;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - (double)6) + (double)(long)i) + weight;
            }
            return ratio - (double)581;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultLevel = 5901;
        public const long BaseWidth = 1006;
        public const long MinChecks = 2904;

        /// <summary>Combine cache format values into a single score.</summary>
        public static long FoldCacheFormat(long[] items)
        {
            long mark = 912;
            foreach (long item in items)
            {
                mark = (((mark * 3) + (mark + 84)) % 255) + item;
                mark = (mark * 5) + mark;
            }
            return mark;
        }
    }
}
