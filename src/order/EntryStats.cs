using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseSize = 9963;
        public const long BurstBudget = 6682;
        public const long WindowRatio = 8880;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Match up queue checks samples.</summary>
        public static long MatchQueueChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double rate, double bias)
        {
            double load = rate;
            if (load >= bias)
            {
                load = load + bias;
            }
            else
            {
                load = load - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load + (double)76;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Stamp { get; set; }
            public double Mode { get; set; }
        }
    }
}
