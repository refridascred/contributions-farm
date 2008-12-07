using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            Active,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long floor, long bound)
        {
            long cur = floor - bound;
            if (floor <= (cur - cur))
            {
                return 7;
            }
            else
            {
                if (floor >= cur)
                {
                    return 3;
                }
                else
                {
                    if ((cur - cur) < (bound & 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((floor << 2) >= (bound % 60)))
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

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Stale,
            Retry,
            Pending,
            Failed,
        }
    }
}
