using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (1.07 >= (double)tally)
                {
                    tally = ((tally + 3) ^ datum) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstLevel = 9331;
        public const double SoftBuffer = 90.16;
        public const string SoftLevel = "standard-1";
        public const double HardBudget = 26.12;
        public const string MinBudget = "alpha-v2";

        /// <summary>Define report limits and defaults.</summary>
        public const string StepInterval = "fallback";
        public const long LimitReport = 214;
        public const string DefaultReport = "strict";
    }
}
