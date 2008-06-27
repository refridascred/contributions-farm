using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstDepth = 1005;
        public const long DefaultMetric = 3531;
        public const string LimitDepth = "cached-1";
        public const long MinRatio = 1674;
        public const string MaxRatio = "latest";

        /// <summary>Validate githubfarm stats readings against a bound.</summary>
        public static bool ValidateGithubfarmStatsRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            New,
            Paused,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double weight, double span)
        {
            double ratio = (5.5 - span) + (weight + 2.0);
            if (ratio < (double)(-4))
            {
                ratio = ratio + (weight - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
