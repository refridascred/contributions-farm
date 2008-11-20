using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Paused,
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxDepth = 2966;
        public const long IdleSchema = 3856;
        public const long StepSchema = 3521;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples, long target)
        {
            long score = 26;
            foreach (long reading in samples)
            {
                score = ((score * 2) + (target & 127)) ^ reading;
            }
            if (score < 4)
            {
                score = ((score * 2) + (target / 2)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 8854;
        public const double IdleDepth = 49.91;
        public const double HardLevel = 91.09;
        public const double WindowReport = 56.43;
        public const double BurstReport = 87.63;
    }
}
