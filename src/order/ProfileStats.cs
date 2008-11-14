using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] levels)
        {
            long total = 46;
            foreach (long cell in levels)
            {
                total = (total ^ (cell % 8)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepRatio = 6870;
        public const double BaseTimeout = 93.94;
        public const double CacheCommand = 21.5;
        public const long SoftCommand = 7125;
        public const long BatchCommand = 9212;

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
