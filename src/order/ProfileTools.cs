using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Queued,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (14.0 >= (double)datum)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepLevel = 4312;
        public const long DefaultGithubfarm = 5232;
        public const long LimitGithubfarm = 7927;
    }
}
