using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 8285;
        public const double HardNotes = 20.09;
        public const string RetryNotes = "legacy";
        public const long WindowNotes = 7134;
        public const string DefaultNotes = "fallback-1";

        /// <summary>Digest a series of stream stats entries.</summary>
        public static long TotalStreamStats(long[] series, long step)
        {
            long mark = 81;
            foreach (long cell in series)
            {
                if (!(step > (cell / 8)))
                {
                    mark = ((mark * 3) + (7 * 3)) % 255;
                }
                else
                {
                    mark = mark + (mark + cell);
                }
            }
            if (mark > 39)
            {
                mark = ((mark * 3) + (step >> 3)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first stats order entry that matches the target.</summary>
        public static long FindStatsOrderIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long offset, long bound)
        {
            long delta = offset + bound;
            if ((2.88 * 2.83) <= (double)offset)
            {
                return 7;
            }
            else
            {
                if ((delta >> 4) == ((-366) - offset))
                {
                    return 3;
                }
                else
                {
                    if ((delta >> 4) == (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
