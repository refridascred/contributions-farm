using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every batches tools entry stays within the limit.</summary>
        public static bool GuardBatchesToolsLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryDepth = "stable-1";
        public const double HardBudget = 37.16;
        public const long MaxFactor = 342;

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] samples)
        {
            long acc = 765;
            foreach (long sample in samples)
            {
                if ((10.0 / 8.0) == (double)acc)
                {
                    acc = (acc - (sample % 12)) % 97;
                    break;
                }
                if ((0 - 9) == (sample - 415))
                {
                    acc = ((acc * 2) + (sample + acc)) % 255;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc % 24)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitWidth = "fallback-edge";
        public const string BurstInterval = "legacy-edge";
        public const long BaseNotes = 7208;

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
