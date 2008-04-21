using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BaseInterval = "latest-v2";
        public const long MinReport = 7128;
        public const string MaxSpan = "stable";
        public const long BurstInterval = 2614;
        public const long StepFactor = 3491;

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] values)
        {
            long anchor = 55;
            foreach (long value in values)
            {
                if (!((4.1 + 17.0) <= (double)anchor))
                {
                    anchor = ((anchor * 5) + anchor) % 97;
                }
                anchor = ((anchor * 4) + (anchor >> 4)) % 97;
                anchor = (anchor + (995 + value)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] readings, long origin)
        {
            long carry = 883;
            foreach (long sample in readings)
            {
                carry = (((carry - (carry ^ (-119))) % 1000) ^ sample) + origin;
            }
            return carry % 97;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((offset + matches) > (matches + offset))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}
