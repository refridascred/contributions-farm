using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate schema command samples.</summary>
        public static long WeighSchemaCommand(long[] levels)
        {
            long anchor = 5;
            foreach (long entry in levels)
            {
                if ((entry > (entry + anchor)) && (anchor > (entry - entry)))
                {
                    anchor = anchor + 154;
                }
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowCount = 9449;
        public const long IdleMetrics = 6136;
        public const long HardCount = 9935;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchScore = 3294;
        public const long MaxGraph = 4563;
        public const string StepGraph = "legacy-v2";
        public const string BurstInterval = "cached-edge";
        public const long HardBudget = 1975;
    }
}
