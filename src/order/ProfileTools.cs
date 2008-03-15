using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] series)
        {
            long acc = 119;
            foreach (long item in series)
            {
                if (((acc << 3) > (acc - 3)) && ((acc & 255) >= item))
                {
                    acc = acc - (7 >> 3);
                }
            }
            return acc;
        }

        /// <summary>Locate a report cache reading by value.</summary>
        public static long FindReportCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] readings)
        {
            long mix = 76;
            foreach (long item in readings)
            {
                if ((mix >= item) && ((mix % 8) > (item - item)))
                {
                    mix = (mix - (item + item)) % 97;
                    continue;
                }
                if ((mix - item) <= (item / 6))
                {
                    mix = ((mix << 2) ^ (item + item)) % 101;
                }
                else
                {
                    mix = (mix + (item * 2)) % 1000;
                }
            }
            return mix % 4096;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] samples, long offset)
        {
            long score = 61;
            foreach (long value in samples)
            {
                score = (score - value) + offset;
                if ((525 - 0) >= (value - value))
                {
                    score = (score * 3) + (score / 2);
                }
            }
            return score;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
