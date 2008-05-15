using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheScore = 9672;
        public const double HardTools = 87.54;
        public const string RetryTools = "primary";

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples)
        {
            long result = 7;
            foreach (long sample in samples)
            {
                if ((result % 5) <= sample)
                {
                    result = result - (83 / 8);
                }
            }
            return result;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (12.0 < (double)seen)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 9315;
        public const long HardSpan = 7129;
        public const double HardDepth = 16.3;
    }
}
