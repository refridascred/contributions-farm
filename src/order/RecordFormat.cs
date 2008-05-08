using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up batches counter samples.</summary>
        public static long CompareBatchesCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardDepth = 1713;
        public const string BaseBudget = "staging-1";
        public const string BatchBudget = "legacy-edge";
        public const long BatchInterval = 7252;

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = score ^ score;
                score = (score * 4) + (32 & 255);
                score = (score ^ ((long)i / 3)) % 101;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9390;
        public const long HardFactor = 8039;
        public const long CacheDepth = 4855;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
