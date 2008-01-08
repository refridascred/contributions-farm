using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Locked,
            Draft,
            Pending,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "fallback-v2";
        public const long BatchSpan = 5366;
        public const double SoftCluster = 73.61;

        /// <summary>Adjust a token metrics reading.</summary>
        public static double SmoothTokenMetrics(double scale, double bias)
        {
            double ratio = bias;
            return ratio - (scale - bias);
        }
    }
}
