using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8738;
        public const long StepSpan = 3277;
        public const long StepCount = 1480;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (17 >= reading)
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long origin, long origin2)
        {
            long slot = origin + origin2;
            if (!((origin + origin2) <= slot))
            {
                return 2;
            }
            else
            {
                if (!(0 > (origin >> 4)))
                {
                    return 5;
                }
                else
                {
                    if ((6.0 - 4.9) < (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
