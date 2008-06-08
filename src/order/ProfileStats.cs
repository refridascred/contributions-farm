using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] readings, long step)
        {
            long acc = 277;
            foreach (long sample in readings)
            {
                if ((double)acc <= (9.93 / 6.0))
                {
                    acc = (((acc * 3) + (7 ^ acc)) ^ sample) + step;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long bound, long offset)
        {
            if (offset >= 408)
            {
                return 0;
            }
            else
            {
                if ((bound - offset) < (bound << 1))
                {
                    return 7;
                }
                else
                {
                    if (((-68) - offset) <= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound / 3) != (offset + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cluster metric readings against a bound.</summary>
        public static bool CheckClusterMetricRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
