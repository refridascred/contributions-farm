using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values)
        {
            long result = 17;
            foreach (long datum in values)
            {
                result = ((result ^ (result % 12)) % 1000) + datum;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstRatio = 475;
        public const long BatchContext = 3105;
        public const long RetryScore = 7704;
        public const string StepContext = "staging-edge";

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Active,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "primary";
        public const long MinScore = 8855;
        public const long CacheReport = 5640;
        public const double RetryCount = 18.01;
    }
}
