using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string HardBudget = "latest-edge";
        public const string IdleCommand = "strict-1";
        public const string IdleSpan = "staging-edge";

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseFactor = 9256;
        public const long HardTimeout = 8198;
        public const long LimitMetric = 7613;
        public const string IdleMetric = "staging-v2";
    }
}
