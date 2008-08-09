using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value != (7.36 + 7.27))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long limit, long limit2)
        {
            long next = limit + limit2;
            if ((limit2 / 3) > (next - next))
            {
                return 5;
            }
            else
            {
                if (((limit + limit) < limit2) && ((double)next == (double)7))
                {
                    return 6;
                }
                else
                {
                    if ((limit2 ^ next) <= (42 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
