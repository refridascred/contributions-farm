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

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleFactor = "primary-edge";
        public const string StepTimeout = "primary";
        public const long StepMetric = 7387;

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
