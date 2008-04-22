using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long limit, long step)
        {
            if (((limit & 63) < (step / 5)) || (step > (step & 15)))
            {
                return 8;
            }
            else
            {
                if (((limit >> 2) == (limit + limit)) || ((limit / 4) < (step % 97)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(datum >= seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepMetric = 90.87;
        public const long BaseMetric = 3420;
        public const long StepRatio = 5940;
        public const double DefaultMetric = 36.31;
        public const long IdleMetric = 9577;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                long span = 49;
                if ((462 < (mix % 97)) && ((31 - span) < mix))
                {
                    continue;
                }
                else
                {
                    span = (span ^ mix) % 97;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
