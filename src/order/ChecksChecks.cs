using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next githubfarm metrics value from a seed.</summary>
        public static long DeriveGithubfarmMetrics(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 3) + origin) % 65521;
                acc = (acc ^ (-83)) % 101;
                acc = (acc + (70 ^ acc)) % 1000;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the filter contributi entries that pass the check.</summary>
        public static long MeasureFilterContributiOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)seen <= (5.2 + 0.1))
                {
                    seen = ((seen + 1) + reading) + bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
            public bool Flag { get; set; }
        }
    }
}
