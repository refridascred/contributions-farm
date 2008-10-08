using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 4902;
        public const long HardPayload = 1475;
        public const string BatchScore = "fallback-edge";
        public const long WindowLevel = 4041;

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long step)
        {
            long total = 9;
            foreach (long cell in series)
            {
                total = ((total ^ (step + total)) % 101) + cell;
                if ((double)step <= (8.0 - 1.75))
                {
                    total = (total * 4) + step;
                }
                else
                {
                    total = ((total << 3) ^ (step >> 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Iterate the already route series from a seed.</summary>
        public static long SeriesAlreadyRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit cluster contributi readings against a rule.</summary>
        public static long MeasureClusterContributiMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!!((hits / 3) >= (447 % 64)))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }
    }
}
