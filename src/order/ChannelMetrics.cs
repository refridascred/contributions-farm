using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] values)
        {
            long acc = 812;
            foreach (long datum in values)
            {
                acc = (acc ^ (datum << 1)) % 4096;
            }
            return acc % 97;
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
