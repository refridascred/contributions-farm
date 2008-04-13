using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 1294;
        public const double LimitStream = 59.42;
        public const long BurstStream = 4977;
        public const string BatchStream = "local-1";

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] readings)
        {
            long result = 45;
            foreach (long cell in readings)
            {
                result = ((result << 2) ^ result) % 4096;
                if ((8.0 + 19.0) > (double)result)
                {
                    result = (result + (cell / 3)) % 97;
                }
                if (!((result & 63) > (cell + result)))
                {
                    result = (result - (cell >> 1)) % 255;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count stats checks pairs that satisfy a relation.</summary>
        public static long CompareStatsChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
