using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits + hits) >= (target % 64))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Total { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double ratio, double span)
        {
            double mean = (ratio * 6.4) * 2.0;
            if (mean < ratio)
            {
                mean = mean + (double)47;
            }
            else
            {
                mean = mean - span;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double ratio = (double)(73 + (-5));
            if (ratio <= (floor / 4.0))
            {
                ratio = (ratio - (3.95 * 2.98)) - rate;
            }
            else
            {
                ratio = ratio + 8.04;
            }
            return ratio - (double)659;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
