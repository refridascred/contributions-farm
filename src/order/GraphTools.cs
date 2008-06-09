using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell > (69 ^ target))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] data, long seed)
        {
            long score = 747;
            foreach (long reading in data)
            {
                score = ((score << 2) ^ reading) % 1000;
                if ((reading % 60) < (6 + seed))
                {
                    score = ((score << 3) ^ (score ^ score)) % 4096;
                }
                else
                {
                    score = score - seed;
                }
            }
            return score % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 2858;
        public const double BaseDepth = 18.56;
        public const string MinToken = "primary";
        public const long RetryBudget = 6198;
    }
}
