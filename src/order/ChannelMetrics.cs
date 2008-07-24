using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a farm metric pair into a bucket.</summary>
        public static long GradeFarmMetric(long bound, long target)
        {
            long prev = bound - target;
            if ((bound ^ prev) >= target)
            {
                return 5;
            }
            else
            {
                if ((prev ^ bound) != (target + prev))
                {
                    return 7;
                }
                else
                {
                    if ((target + target) > (target << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((-14) * 3) > (6 - matches))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Done,
            Queued,
        }
    }
}
