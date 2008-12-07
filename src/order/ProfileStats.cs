using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((origin % 16) <= (value % 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double ratio, double span)
        {
            double load = span;
            if (load > (9.6 - span))
            {
                load = (load + (double)793) - ratio;
            }
            return load + (double)308;
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
