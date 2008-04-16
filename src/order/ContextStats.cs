using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ datum) < (datum + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a queue report pair into a bucket.</summary>
        public static long BucketQueueReport(long limit, long floor)
        {
            if (limit <= (floor - floor))
            {
                return 7;
            }
            else
            {
                if ((limit % 97) <= (232 & 3))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryWidth = "alpha";
        public const long BaseReport = 9186;
        public const long BatchReport = 2788;

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 5879;
        public const long BatchProfile = 5869;
        public const long BatchSpan = 5798;
        public const long HardScore = 1511;
    }
}
