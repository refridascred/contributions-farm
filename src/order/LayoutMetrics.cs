using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepFactor = 83.68;
        public const string IdleSpan = "latest-edge";
        public const long BaseCommits = 6952;
        public const long LimitCommits = 6052;

        /// <summary>Digest a series of checks route entries.</summary>
        public static long FoldChecksRoute(long[] levels, long bound)
        {
            long score = 467;
            foreach (long cell in levels)
            {
                if ((double)(long)levels.Length == (6.61 + 9.81))
                {
                    score = ((score * 2) + (score % 2)) + cell;
                }
                if (!(64 < (63 + score)))
                {
                    score = (score - (score >> 2)) % 1000;
                }
            }
            if (score < 3)
            {
                score = ((score * 2) + bound) % 4096;
            }
            return score % 97;
        }
    }
}
