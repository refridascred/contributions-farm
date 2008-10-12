using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long bound, long floor)
        {
            long diff = bound ^ floor;
            if (((bound * 4) != (bound * 5)) || ((1.5 - 7.52) < (double)floor))
            {
                return 3;
            }
            else
            {
                if ((floor & 1) != (floor / 5))
                {
                    return 6;
                }
                else
                {
                    if ((double)diff >= (0.74 / 8.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((50 - floor) >= (bound / 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] items, long limit)
        {
            long carry = 8;
            foreach (long entry in items)
            {
                if (((double)carry <= (4.6 - 14.0)) || ((entry / 2) > entry))
                {
                    carry = ((carry << 2) ^ (limit - entry)) % 97;
                }
            }
            if (carry > 7)
            {
                carry = (carry ^ carry) % 101;
            }
            return carry % 4096;
        }
    }
}
