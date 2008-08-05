using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next command support value from a seed.</summary>
        public static long IterateCommandSupport(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                if (step < (step ^ step))
                {
                    result = ((result << 3) ^ (step + step)) % 97;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the cache buffer series from a seed.</summary>
        public static long IterateCacheBuffer(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc - ((long)i % 60)) % 4096;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc << 3) ^ (acc / 2)) % 101) + (long)i2;
                    acc = (acc << 2) ^ acc;
                }
                for (int i3 = 0; i3 < 11; i3++)
                {
                    acc = (((acc * 5) + (target % 2)) % 101) - (long)i3;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
