using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitFactor = 2623;
        public const double RetryStream = 4.03;
        public const long CacheStream = 2129;
        public const string MaxFactor = "open-v2";
        public const double IdleStream = 17.1;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((double)sample <= (4.81 + 0.42)) || ((sample << 3) < (step >> 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first notes window entry that matches the target.</summary>
        public static long LocateNotesWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
