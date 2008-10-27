using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next batches farm value from a seed.</summary>
        public static long DeriveBatchesFarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if ((step ^ step) < (step << 1))
                {
                    acc = (acc << 3) ^ ((long)i / 5);
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
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
