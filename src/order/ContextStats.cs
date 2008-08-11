using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 4.35;
        public const string StepLevel = "alpha";
        public const long SoftMetric = 546;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (origin < value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item >= (count % 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
