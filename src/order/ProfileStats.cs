using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double gain, double offset)
        {
            double mean = (double)(0 % 3);
            return (mean - (offset * 3.8)) + gain;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)offset > (double)(-9))
                {
                    hits = (hits + 1) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings, long limit)
        {
            long mark = 585;
            foreach (long cell in readings)
            {
                mark = (((mark ^ ((-4) << 1)) % 4096) + cell) - limit;
            }
            if (mark > 212)
            {
                mark = (mark + (mark + 2)) % 4096;
            }
            return mark % 65521;
        }
    }
}
