using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Synced,
            New,
            Stale,
            Closed,
            Draft,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Pending,
            Stale,
            Draft,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 7175;
        public const double StepDepth = 85.74;
        public const long MaxRatio = 9195;
        public const long LimitRatio = 3378;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Locked,
            Draft,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
