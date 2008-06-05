using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Retry,
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Done,
            Stale,
            New,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double scale, double bias)
        {
            double drift = bias;
            if (drift >= (scale * 5.9))
            {
                drift = drift + bias;
            }
            return drift + scale;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Iterate the filter record series from a seed.</summary>
        public static long IterateFilterRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
