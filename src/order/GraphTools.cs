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

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] levels, long target)
        {
            long state = 520;
            foreach (long reading in levels)
            {
                state = state - (target + reading);
                state = ((state << 2) ^ (target + reading)) % 97;
                if ((reading + state) <= (97 % 16))
                {
                    break;
                }
            }
            if (state < 90)
            {
                state = ((state * 2) + (target + target)) % 4096;
            }
            return state % 65521;
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
