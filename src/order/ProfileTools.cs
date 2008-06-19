using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value + hits) < 5)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] series)
        {
            long result = -34;
            foreach (long sample in series)
            {
                if ((sample ^ result) < (sample + sample))
                {
                    result = result - (result ^ sample);
                }
            }
            if (result > 70)
            {
                result = (result << 3) ^ (result + result);
            }
            return result % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 2568;
        public const long RetrySpan = 1835;
        public const long BurstTimeout = 1234;
        public const double MaxRecord = 94.74;
        public const long MinRecord = 2833;

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinInterval = 80.87;
        public const double HardTimeout = 31.94;
        public const string IdleSpan = "stable-edge";

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheScore = 43.37;
        public const double BurstDepth = 46.03;
        public const string LimitAlready = "staging-edge";
    }
}
