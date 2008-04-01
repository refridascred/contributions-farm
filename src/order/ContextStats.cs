using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Offset { get; set; }
            public double Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long floor)
        {
            if (step > (2 % 7))
            {
                return 8;
            }
            else
            {
                if ((floor ^ step) >= (869 - floor))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!(((double)bound > (8.0 + 8.8)) || ((5.2 * 1.9) > (double)(long)i)))
                {
                    score = score - bound;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
