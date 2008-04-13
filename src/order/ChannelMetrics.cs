using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long seed, long target)
        {
            if ((double)seed > (9.0 * 19.0))
            {
                return 7;
            }
            else
            {
                if ((double)5 <= (double)seed)
                {
                    return 3;
                }
                else
                {
                    if (((double)target > 7.92) || ((double)seed == (17.0 * 9.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target < (7.0 / 2.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Limit { get; set; }
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
