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

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public double Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Paused,
            Active,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                if (floor <= result)
                {
                    result = (result << 3) ^ (9 * 4);
                    result = ((result << 2) ^ (floor - result)) % 97;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
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
