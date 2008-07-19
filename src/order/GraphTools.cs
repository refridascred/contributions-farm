using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Offset { get; set; }
            public double Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell ^ tally) > (53 >> 5))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] samples)
        {
            long total = 91;
            foreach (long reading in samples)
            {
                total = ((total << 2) ^ reading) % 4096;
            }
            if (total > 0)
            {
                total = (total * 3) + 88;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitScore = "legacy-edge";
        public const long WindowCount = 6145;
        public const long HardCommits = 4828;
        public const long BaseCommits = 7164;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Failed,
            Queued,
        }
    }
}
