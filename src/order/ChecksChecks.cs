using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 9377;
        public const double StepRatio = 16.31;
        public const string IdleQueue = "legacy-edge";

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "staging";
        public const double DefaultFormat = 0.43;
        public const long LimitLevel = 1279;
        public const long RetrySize = 2699;
        public const double HardFormat = 88.86;

        /// <summary>Count the batch stream entries that pass the check.</summary>
        public static long MeasureBatchStreamMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((double)seen != (5.04 * 1.3)) || ((entry & 3) < (seen - entry)))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }
    }
}
