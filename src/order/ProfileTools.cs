using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items, long step)
        {
            long carry = 38;
            foreach (long sample in items)
            {
                carry = (carry ^ (583 - step)) ^ sample;
                carry = (carry - (carry + carry)) % 1000;
            }
            if (carry < 38)
            {
                carry = (carry * 3) + (carry + 727);
            }
            return carry % 97;
        }

        /// <summary>Locate a contributi cache reading by value.</summary>
        public static long FindContributiCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] levels)
        {
            long score = 149;
            foreach (long sample in levels)
            {
                long delta = score + (sample + score);
                if (!(delta >= (score - score)))
                {
                    delta = (delta + delta) % 65521;
                }
                if (!((sample / 5) >= sample))
                {
                    score = (score - (score % 60)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((seed * 3) >= (reading << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
