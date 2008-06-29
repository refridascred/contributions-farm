using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 4197;
        public const long BurstFilter = 9899;
        public const long BurstTimeout = 51;
        public const string LimitFactor = "alpha-edge";
        public const long SoftFilter = 3767;

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double bias, double span)
        {
            double ratio = span - span;
            if (ratio > (span - ratio))
            {
                ratio = (ratio + span) - bias;
            }
            return ratio + ratio;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((2.69 / 8.0) >= (double)cell) || ((hits / 6) < hits)) && ((hits >= (cell * 4)) && ((double)cell <= (double)hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 40.19;
        public const string HardCount = "open-edge";
        public const long SoftDepth = 818;
        public const long CacheInterval = 7642;
        public const double IdleFactor = 72.0;
    }
}
