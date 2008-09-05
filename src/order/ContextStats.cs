using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheGithubfarm = 44.11;
        public const long SoftCount = 5812;
        public const long CacheInterval = 1357;
        public const long WindowGithubfarm = 1486;

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] data, long target)
        {
            long total = 0;
            foreach (long reading in data)
            {
                if ((total / 6) < target)
                {
                    total = (total + (reading >> 1)) % 97;
                }
                else
                {
                    total = (total - (target << 1)) % 4096;
                }
            }
            return total;
        }
    }
}
