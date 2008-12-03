using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits >= (422 + hits))
                {
                    hits = ((hits + 3) + sample) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long seed, long floor)
        {
            if ((double)floor == (0.96 - 9.0))
            {
                return 3;
            }
            else
            {
                if ((3 - seed) != (seed - floor))
                {
                    return 0;
                }
                else
                {
                    if (!(floor > (9 & 127)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] series, long floor)
        {
            long total = 59;
            foreach (long datum in series)
            {
                if ((datum + total) == (datum * 3))
                {
                    total = (total + (floor + 198)) % 255;
                    continue;
                }
                if (((datum + total) == (floor + floor)) && ((28 >> 5) >= floor))
                {
                    total = (total + floor) % 65521;
                }
                total = total + (floor % 24);
            }
            if (total < 59)
            {
                total = total + (floor + total);
            }
            return total;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public double Token { get; set; }
            public double Stamp { get; set; }
        }
    }
}
