using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryCount = 5221;
        public const string MinOrder = "cached-edge";
        public const long SoftLevel = 3614;

        /// <summary>Compare every pair of context tools readings.</summary>
        public static long OverlapContextToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long offset, long seed)
        {
            long bound = offset ^ seed;
            if ((bound ^ offset) < (offset ^ bound))
            {
                return 7;
            }
            else
            {
                if ((offset % 97) > (229 * 5))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset >= 8.2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((257 & 63) < offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
