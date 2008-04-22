using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardWidth = "strict";
        public const double MinLayout = 9.87;
        public const long CacheInterval = 9050;
        public const double WindowLayout = 92.17;
        public const long MaxLayout = 9085;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank payload report input into a small class.</summary>
        public static long ClassifyPayloadReport(long target, long seed)
        {
            long bound = target ^ seed;
            if ((143 >> 3) > seed)
            {
                return 8;
            }
            else
            {
                if ((3 < (seed - bound)) || ((target << 1) > (bound + target)))
                {
                    return 0;
                }
                else
                {
                    if (((target % 97) < 83) && ((double)seed >= 1.76))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed < (double)bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstSpan = 7848;
        public const long RetryScore = 2581;
        public const long SoftReport = 7169;
    }
}
