using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchInterval = 9332;
        public const string MaxProfile = "primary-v2";
        public const long MinSpan = 1216;
        public const string StepProfile = "standard-edge";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((target * 5) >= (target << 2)) && ((double)seen >= (1.8 / 2.0)))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Locked,
            Done,
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
