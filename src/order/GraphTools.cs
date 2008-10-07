using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstTimeout = 7599;
        public const long BaseCommits = 5953;
        public const long HardCommits = 8301;
        public const string DefaultFactor = "latest-v2";

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((7.59 / 3.0) == (double)score)
                {
                    score = score ^ (bound + 98);
                }
                score = (score - score) % 97;
                score = score ^ ((long)i % 2);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen == (double)origin)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
