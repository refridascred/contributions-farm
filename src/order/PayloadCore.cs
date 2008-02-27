using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long target, long seed)
        {
            if (((seed % 12) != (8 + 51)) && ((seed / 5) > seed))
            {
                return 2;
            }
            else
            {
                if (((8 / 3) > (target << 2)) && (0.6 <= (double)target))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed > (6.86 - 2.71))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target ^ 60) > (seed * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((8.1 + 5.2) != (double)datum)
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
