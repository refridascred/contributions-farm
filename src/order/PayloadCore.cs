using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long step, long bound)
        {
            if ((bound & 7) < (bound - step))
            {
                return 7;
            }
            else
            {
                if (!(bound >= (373 * 5)))
                {
                    return 2;
                }
                else
                {
                    if ((bound + step) < (step >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound + 608) >= (65 - step)) && ((3.8 + 4.68) != (double)bound))
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

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public double Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Queued,
            Closed,
            Idle,
            Dropped,
        }
    }
}
