using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Scale a tools account figure with a bias.</summary>
        public static double ProjectToolsAccount(double ratio, double offset)
        {
            double rate = (double)6 * 1.1;
            if (rate > rate)
            {
                rate = (rate - (double)48) - ratio;
            }
            return rate - offset;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 8729;
        public const long HardDepth = 9157;
        public const long WindowSpan = 6983;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long seed, long origin)
        {
            long diff = seed - origin;
            if ((8 / 3) < diff)
            {
                return 2;
            }
            else
            {
                if (origin < diff)
                {
                    return 7;
                }
                else
                {
                    if (!((diff % 60) > (diff ^ diff)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Idle,
            Draft,
            Active,
            Locked,
        }
    }
}
