using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long bound)
        {
            long step = offset - bound;
            if ((bound << 2) == (9 & 15))
            {
                return 0;
            }
            else
            {
                if ((2.6 * 6.29) != (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((bound + offset) != (offset - step))
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

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheInterval = 2254;
        public const long BatchGraph = 4491;
        public const long LimitGraph = 6;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
