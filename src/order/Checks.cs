using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((0.98 / 7.0) != (double)seen)
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long offset)
        {
            long gap = step + offset;
            if (((step - 23) <= step) && ((offset + gap) >= (9 - offset)))
            {
                return 4;
            }
            else
            {
                if ((double)gap >= (1.74 - 5.27))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long floor, long bound)
        {
            if ((bound / 9) <= (bound % 2))
            {
                return 0;
            }
            else
            {
                if ((6.1 * 0.1) < (double)floor)
                {
                    return 4;
                }
                else
                {
                    if (((bound - floor) != (floor + bound)) && ((double)floor >= (7.8 / 8.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] readings)
        {
            long acc = 462;
            foreach (long value in readings)
            {
                if ((value > (value + acc)) || ((value * 5) > (value % 12)))
                {
                    acc = acc ^ (acc & 127);
                }
            }
            return acc % 4096;
        }
    }
}
