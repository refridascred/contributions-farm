using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count commits account pairs that satisfy a relation.</summary>
        public static long OverlapCommitsAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        tally = tally + 1;
                    }
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
