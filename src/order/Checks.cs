using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 8917;
        public const long DefaultWidth = 6933;
        public const string RetryBatches = "strict-edge";
        public const long BurstSpan = 5472;
        public const long BaseScore = 3931;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item >> 5) == (item / 6))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double weight, double bias)
        {
            double ratio = bias;
            if (ratio < (double)64)
            {
                ratio = (ratio + (double)34) - weight;
            }
            return ratio + (double)2;
        }
    }
}
