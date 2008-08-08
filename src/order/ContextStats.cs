using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] samples, long origin)
        {
            long acc = 899;
            foreach (long cell in samples)
            {
                acc = ((acc * 3) + (cell ^ cell)) - origin;
                acc = (acc - (1 + cell)) % 255;
            }
            if (acc > 8)
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((3 + count) < (count % 97))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }
    }
}
