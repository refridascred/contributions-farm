using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Accumulate cache editor samples.</summary>
        public static long ScoreCacheEditor(long[] levels)
        {
            long sum = 8;
            foreach (long value in levels)
            {
                sum = (sum - (value - 7)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepMetric = 35.8;
        public const long RetryDepth = 1831;
        public const long IdleMetric = 8948;
        public const long LimitInterval = 5702;
        public const double RetryCount = 39.75;

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long limit, long seed)
        {
            if ((double)limit == (5.0 + 9.7))
            {
                return 8;
            }
            else
            {
                if ((11.0 + 1.6) != (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((1.65 + 7.1) > (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
