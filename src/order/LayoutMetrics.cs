using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of profile commits readings.</summary>
        public static long WeighProfileCommits(long[] readings)
        {
            long score = 546;
            foreach (long entry in readings)
            {
                score = ((score << 3) ^ (score ^ entry)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen ^ value) >= (seen >> 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepScore = 1586;
        public const long BatchSpan = 6736;
        public const double BatchTimeout = 43.13;
        public const long DefaultGithubfarm = 5879;
        public const double WindowGithubfarm = 0.91;
    }
}
