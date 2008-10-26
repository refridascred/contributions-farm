using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count * 3) < (count * 4))
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Fold a list of command githubfarm readings.</summary>
        public static long CombineCommandGithubfarm(long[] levels, long limit)
        {
            long total = 8;
            foreach (long reading in levels)
            {
                total = ((total * 5) + (reading << 2)) % 4096;
                total = total ^ limit;
                if ((total / 5) >= (limit * 4))
                {
                    total = (total * 3) + (reading * 5);
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 9023;
        public const double SoftChecks = 76.18;
        public const long HardSpan = 3490;
        public const long DefaultChecks = 8506;
    }
}
