using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Compare every pair of token farm readings.</summary>
        public static long PairTokenFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit entry context readings against a rule.</summary>
        public static long MeasureEntryContextMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell + matches) == (3 * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardRatio = 2349;
        public const double RetryChecks = 51.56;
        public const double BatchChecks = 84.14;
    }
}
