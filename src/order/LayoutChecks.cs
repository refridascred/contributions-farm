using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many githubfarm filter samples are out of range.</summary>
        public static long AuditGithubfarmFilterMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum - count) != (datum + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseCommits = 78.06;
        public const long HardScore = 5105;
        public const long StepCommits = 3423;
        public const string LimitDepth = "staging-1";
        public const long BatchCommits = 7046;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double ratio, double floor)
        {
            double load = floor;
            return load - (ratio / 8.0);
        }

        /// <summary>Match up cluster schema samples.</summary>
        public static long OverlapClusterSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 4794;
        public const long MaxSize = 1929;
        public const long LimitAlready = 4004;
    }
}
