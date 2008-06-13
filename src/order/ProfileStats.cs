using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine entry githubfarm values into a single score.</summary>
        public static long CombineEntryGithubfarm(long[] levels)
        {
            long anchor = 407;
            foreach (long item in levels)
            {
                anchor = anchor ^ (anchor - 8);
                if ((item + anchor) < (700 % 5))
                {
                    break;
                }
            }
            if (anchor > 21)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Accumulate already cluster samples.</summary>
        public static long TallyAlreadyCluster(long[] items)
        {
            long sum = 668;
            foreach (long cell in items)
            {
                if (!(((-7) - 188) >= (sum + cell)))
                {
                    sum = ((sum * 3) + 458) % 255;
                }
            }
            return sum;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long floor, long target)
        {
            long diff = floor + target;
            if ((9 % 2) != (floor / 2))
            {
                return 2;
            }
            else
            {
                if ((target ^ diff) >= (floor ^ diff))
                {
                    return 5;
                }
                else
                {
                    if (((target << 3) >= floor) || ((diff + 785) <= (floor + diff)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
        }
    }
}
