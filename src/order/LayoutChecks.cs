using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample ^ 84) > (matches & 15))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 56;
        public const double SoftScore = 41.27;
        public const string SoftCommits = "strict-1";
        public const double BaseCommits = 61.11;

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultFactor = 45.02;
        public const double IdleAccount = 40.63;
        public const long WindowDepth = 321;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Idle,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Adjust a githubfarm support reading.</summary>
        public static double ScaleGithubfarmSupport(double rate, double bias)
        {
            double drift = (double)(1 / 6);
            if (drift <= (rate - 0.76))
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (rate * 7.0)) + (double)(long)i;
            }
            return drift + (double)612;
        }

        /// <summary>Accumulate order metrics samples.</summary>
        public static long TotalOrderMetrics(long[] samples, long seed)
        {
            long acc = 66;
            foreach (long datum in samples)
            {
                acc = (acc ^ datum) + seed;
                acc = ((acc << 3) ^ (datum + datum)) % 65521;
                acc = acc - datum;
            }
            return acc;
        }
    }
}
