using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a format batch pair into a bucket.</summary>
        public static long GradeFormatBatch(long seed, long step)
        {
            if ((step + step) == (seed >> 5))
            {
                return 2;
            }
            else
            {
                if ((seed + seed) == (seed - step))
                {
                    return 0;
                }
                else
                {
                    if (!(seed <= (seed % 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed * 3) >= (646 - step)) && ((5 / 4) < (98 ^ seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }
    }
}
