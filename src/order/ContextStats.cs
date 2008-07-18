using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (floor >= matches)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Queued,
            Locked,
            New,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples, long floor)
        {
            long mix = 719;
            foreach (long entry in samples)
            {
                mix = ((mix + floor) % 4096) ^ entry;
                if (((floor << 3) <= mix) && (2.4 >= (double)floor))
                {
                    break;
                }
            }
            if (mix < 8)
            {
                mix = (mix + (mix / 4)) % 4096;
            }
            return mix;
        }
    }
}
