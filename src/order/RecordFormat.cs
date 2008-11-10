using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long offset, long seed)
        {
            long cur = offset - seed;
            if ((seed + seed) >= offset)
            {
                return 8;
            }
            else
            {
                if (!(9.0 >= (double)cur))
                {
                    return 0;
                }
                else
                {
                    if (((offset - cur) > 78) && ((offset / 2) == (seed >> 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                if ((double)total != (6.7 / 3.0))
                {
                    total = (total - target) % 65521;
                }
                else
                {
                    total = (total + target) % 65521;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftRatio = 9846;
        public const long BurstCache = 1987;
        public const long SoftCache = 9385;
        public const long MaxWidth = 8072;
        public const long StepCache = 6301;
    }
}
