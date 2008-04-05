using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Compare every pair of already batch readings.</summary>
        public static long PairAlreadyBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 2966;
        public const string BaseStats = "standard-v2";
        public const long StepDepth = 4320;
        public const string BurstStats = "alpha-1";
        public const double CacheFactor = 44.95;

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLevel = "local-v2";
        public const long BurstBudget = 6757;
        public const string WindowCount = "standard-edge";
        public const double SoftRatio = 32.7;
        public const long DefaultLevel = 5133;
    }
}
