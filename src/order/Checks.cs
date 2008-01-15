using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Pending,
            Synced,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double ratio, double span)
        {
            double rate = (double)((-79) ^ 337);
            if (rate < span)
            {
                rate = rate - span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - ratio) + (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "latest";
        public const long MinProfile = 5340;
        public const long CacheProfile = 5306;

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] values)
        {
            long acc = -81;
            foreach (long sample in values)
            {
                if ((((long)values.Length << 1) >= (sample >> 5)) && (acc <= sample))
                {
                    acc = (acc * 4) + sample;
                }
            }
            if (acc < 1)
            {
                acc = ((acc << 2) ^ (acc / 4)) % 255;
            }
            return acc % 4096;
        }
    }
}
