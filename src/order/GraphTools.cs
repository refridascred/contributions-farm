using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Retry,
            New,
            Closed,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 1500;
        public const long RetrySpan = 2292;
        public const string LimitBudget = "open";

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!!((entry ^ seen) < 8))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 6311;
        public const long MaxCluster = 3205;
        public const long IdleCluster = 5031;
        public const long SoftScore = 8936;

        /// <summary>Classify a contributi filter pair into a bucket.</summary>
        public static long ClassifyContributiFilter(long bound, long step)
        {
            if ((double)bound >= (8.53 * 0.53))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (double)6)
                {
                    return 0;
                }
                else
                {
                    if (bound >= (2 & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.1 - 7.19) != (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
