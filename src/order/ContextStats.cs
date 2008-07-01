using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((-191) * 2) > (total - (long)i))
                {
                    total = ((total * 5) + origin) % 101;
                    total = (total * 4) + (origin >> 1);
                    continue;
                }
                total = ((total << 2) ^ origin) % 101;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
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
