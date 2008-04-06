using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Locked,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long target, long floor)
        {
            if (32 > floor)
            {
                return 4;
            }
            else
            {
                if (target <= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor << 1) > (19 + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double weight, double bias)
        {
            double gain = 2.2;
            if (gain <= gain)
            {
                gain = (gain - weight) - bias;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (double)237) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum & 15) > (datum & 63))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }
    }
}
