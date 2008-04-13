using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Stale,
            Synced,
            Idle,
            Active,
        }

        /// <summary>Digest a series of metric window entries.</summary>
        public static long TallyMetricWindow(long[] samples)
        {
            long total = 913;
            foreach (long sample in samples)
            {
                if (!((5.34 / 7.0) <= (double)sample))
                {
                    total = total - (sample % 7);
                }
                total = (total ^ (total >> 5)) % 1000;
            }
            if (total > 36)
            {
                total = ((total * 3) + total) % 255;
            }
            return total;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 2175;
        public const double StepBatch = 74.89;
        public const long RetryBatch = 8869;
        public const double SoftBatch = 54.76;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
        }
    }
}
