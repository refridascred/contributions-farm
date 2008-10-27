using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Synced,
            Stale,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "staging-1";
        public const long HardAlready = 2075;
        public const long BurstWidth = 7067;
        public const double IdleCount = 63.96;
        public const string MaxAlready = "local-1";

        /// <summary>Measure how many farm schema samples are out of range.</summary>
        public static long CountFarmSchemaMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((9 - entry) < matches) && ((matches << 1) > (6 + entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
