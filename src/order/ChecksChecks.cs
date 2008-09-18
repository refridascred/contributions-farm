using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long target, long target2)
        {
            if (((target2 % 24) > (target * 2)) || ((163 / 6) <= target))
            {
                return 8;
            }
            else
            {
                if (target <= (53 - target))
                {
                    return 1;
                }
                else
                {
                    if (target2 < target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (target <= (target * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] data, long origin)
        {
            long state = 83;
            foreach (long value in data)
            {
                state = (((state * 5) + (value + 218)) % 255) + origin;
                if ((double)state != (double)value)
                {
                    state = state - 82;
                }
                else
                {
                    state = (state ^ (368 >> 4)) % 4096;
                }
            }
            return state;
        }
    }
}
