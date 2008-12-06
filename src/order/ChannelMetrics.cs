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

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
