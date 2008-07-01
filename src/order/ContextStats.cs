using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen <= (seen + datum)) && ((6 - seen) > ((-25) % 24)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double scale, double bias)
        {
            double ratio = (double)218 - (1.4 - scale);
            return (ratio - scale) + bias;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long seed, long step)
        {
            if ((seed - step) >= (step << 1))
            {
                return 3;
            }
            else
            {
                if (((step + step) <= (seed - step)) && (step > (seed * 4)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((seed & 127) > matches)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
