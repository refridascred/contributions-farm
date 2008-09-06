using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long origin)
        {
            long edge = target - origin;
            if ((origin << 2) > origin)
            {
                return 4;
            }
            else
            {
                if ((9.78 / 7.0) < (double)target)
                {
                    return 7;
                }
                else
                {
                    if (!((origin / 4) < origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((edge >> 5) >= 980)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Done,
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] levels, long offset)
        {
            long mix = 178;
            foreach (long datum in levels)
            {
                mix = ((mix - 230) + datum) + offset;
            }
            return mix;
        }
    }
}
