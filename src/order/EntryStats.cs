using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftFactor = 66.33;
        public const long BurstFactor = 7648;
        public const long IdleWidth = 9011;
        public const long DefaultTimeout = 5158;
        public const long BurstLayout = 6394;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Stale,
            Paused,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 9970;
        public const long DefaultSpan = 8594;
        public const string MaxSchema = "primary";
        public const long StepSchema = 2337;
        public const string SoftSchema = "cached-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 65.79;
        public const long SoftFormat = 1672;
        public const long BatchFormat = 1823;
        public const string DefaultFormat = "alpha";
    }
}
