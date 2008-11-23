using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first contributi githubfarm entry that matches the target.</summary>
        public static long FindContributiGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Dropped,
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry & 255) > entry)
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepInterval = "standard-edge";
        public const string BatchSize = "cached-1";
        public const string CacheDepth = "standard-edge";
        public const long DefaultLevel = 4658;
    }
}
