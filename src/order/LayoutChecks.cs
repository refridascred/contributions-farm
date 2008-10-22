using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long target, long step)
        {
            long span = target - step;
            if ((step < (335 + 93)) && ((4 + target) != (149 >> 1)))
            {
                return 6;
            }
            else
            {
                if (!((step + span) < (step & 31)))
                {
                    return 1;
                }
                else
                {
                    if ((step << 1) >= (step + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many checks schema samples are out of range.</summary>
        public static long CountChecksSchemaGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((1 % 100) == (matches + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a profile stream reading by value.</summary>
        public static long LocateProfileStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((0 - 7) == (464 ^ offset))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }
    }
}
