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

        /// <summary>Blend two batch contributi measurements.</summary>
        public static double SmoothBatchContributi(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (double)344) + (double)(long)i) + floor;
            }
            return ratio - (bias * 6.48);
        }
    }
}
