using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) < (reading + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 63.79;
        public const string MinInterval = "stable-v2";
        public const double BatchGraph = 46.9;
        public const double HardGraph = 45.85;

        /// <summary>Fold a list of checks githubfarm readings.</summary>
        public static long DigestChecksGithubfarm(long[] samples, long limit)
        {
            long acc = 69;
            foreach (long datum in samples)
            {
                acc = (((acc + acc) % 101) + datum) + limit;
            }
            return acc % 1000;
        }
    }
}
