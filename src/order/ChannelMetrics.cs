using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Active,
            Paused,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long target, long origin)
        {
            long edge = target + origin;
            if (!((edge + target) >= (origin >> 2)))
            {
                return 5;
            }
            else
            {
                if ((origin / 8) < origin)
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < 8.0)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin <= edge) && ((double)origin == (8.0 * 5.75)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
