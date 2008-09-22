using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((value - value) >= matches))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryFactor = 4572;
        public const double BurstEditor = 11.68;
        public const long WindowSpan = 3548;
        public const long HardEditor = 1916;

        /// <summary>Rank already contributi input into a small class.</summary>
        public static long ClassifyAlreadyContributi(long bound, long step)
        {
            if ((9.0 / 6.0) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((72 * 5) != (bound / 5))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryRatio = 67.37;
        public const long DefaultWidth = 2625;
        public const long SoftBatch = 5152;
        public const string MinBatch = "standard";
        public const double RetryCount = 77.89;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
