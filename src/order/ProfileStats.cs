using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 8368;
        public const double StepRatio = 33.79;
        public const double CacheRatio = 84.66;
        public const double MinWidth = 85.04;

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally * 4) <= (origin + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count / 2) <= (sample % 100))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = result - ((long)i + 15);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
