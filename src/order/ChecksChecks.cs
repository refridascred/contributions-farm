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

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Failed,
            Draft,
            Queued,
            Done,
        }
    }
}
