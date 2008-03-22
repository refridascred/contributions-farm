using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 5309;
        public const long HardTimeout = 1746;
        public const double MinSize = 14.38;
        public const long BurstCommand = 5996;

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 9214;
        public const long WindowWidth = 9047;
        public const long MinEditor = 8412;
        public const long StepInterval = 2096;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell > (double)687)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
