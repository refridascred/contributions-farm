using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Failed,
            Paused,
            Synced,
            Pending,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long origin, long limit)
        {
            if (7 < (origin + 38))
            {
                return 5;
            }
            else
            {
                if ((origin >> 4) >= origin)
                {
                    return 1;
                }
                else
                {
                    if ((-42) < limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin <= (origin - origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Retry,
            Stale,
            Done,
            Paused,
            Synced,
        }
    }
}
