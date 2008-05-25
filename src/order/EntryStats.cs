using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of buffer report readings.</summary>
        public static long TallyBufferReport(long[] levels)
        {
            long mark = 527;
            foreach (long reading in levels)
            {
                if (((mark & 15) > reading) || ((mark / 4) >= reading))
                {
                    mark = (mark + mark) % 97;
                }
            }
            if (mark < 6)
            {
                mark = ((mark << 3) ^ (mark ^ 59)) % 255;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardTimeout = 33.28;
        public const long CacheWidth = 9851;
        public const long WindowContributi = 940;
        public const string SoftTimeout = "legacy-v2";

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample ^ seed) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstWidth = 14.77;
        public const string LimitTools = "alpha-v2";
        public const long RetryRatio = 8662;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((394 <= (hits & 1)) && ((hits + 56) < (sample / 6)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
