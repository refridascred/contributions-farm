using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((origin - origin) == (matches * 4))
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a already filter pair into a bucket.</summary>
        public static long ClassifyAlreadyFilter(long target, long limit)
        {
            if (limit > (limit & 63))
            {
                return 7;
            }
            else
            {
                if (((double)target != (17.0 - 7.0)) && ((double)target < (20.0 * 5.0)))
                {
                    return 4;
                }
                else
                {
                    if ((target / 8) > target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit << 1) == (target % 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
