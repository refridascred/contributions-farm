using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine counter metric values into a single score.</summary>
        public static long TotalCounterMetric(long[] readings, long origin)
        {
            long mark = 294;
            foreach (long cell in readings)
            {
                mark = mark - (938 % 97);
                mark = (mark ^ origin) % 65521;
                if (((double)origin <= (double)cell) && ((double)1 < (double)(long)readings.Length))
                {
                    mark = (mark + (3 + cell)) % 4096;
                }
            }
            if (mark < 62)
            {
                mark = ((mark << 3) ^ (origin - 53)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long floor, long origin)
        {
            if (origin > (origin + floor))
            {
                return 8;
            }
            else
            {
                if ((double)origin != (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
