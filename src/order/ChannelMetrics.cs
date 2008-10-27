using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up stats batches samples.</summary>
        public static long MatchStatsBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "staging-1";
        public const long HardAlready = 2075;
        public const long BurstWidth = 7067;
        public const double IdleCount = 63.96;
        public const string MaxAlready = "local-1";

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 8.55;
        public const long CacheFactor = 1408;
        public const double CacheSize = 81.26;
        public const string HardSize = "latest";
    }
}
