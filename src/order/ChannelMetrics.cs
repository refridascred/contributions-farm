using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the contributi cluster series from a seed.</summary>
        public static long IterateContributiCluster(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                if (!(535 > (target + 5)))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] levels, long floor)
        {
            long score = -6;
            foreach (long reading in levels)
            {
                score = (((score ^ (633 + score)) % 4096) ^ reading) - floor;
            }
            return score % 4096;
        }

        /// <summary>Find the first counter support entry that matches the target.</summary>
        public static long SeekCounterSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
