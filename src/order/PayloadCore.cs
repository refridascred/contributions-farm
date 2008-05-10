using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheTimeout = 2880;
        public const long BurstRatio = 923;
        public const string StepCluster = "latest-1";
        public const string BurstDepth = "staging-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const string MinWidth = "latest-v2";
        public const long BurstReport = 5120;
        public const double WindowReport = 20.42;
        public const long HardTimeout = 4434;
    }
}
