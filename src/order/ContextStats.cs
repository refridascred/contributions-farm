using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Blend two report githubfarm measurements.</summary>
        public static double ScaleReportGithubfarm(double rate, double span)
        {
            double weight = span;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - span) - (double)(long)i) - rate;
            }
            return weight + 7.26;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}
