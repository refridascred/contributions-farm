using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] samples)
        {
            long sum = 11;
            foreach (long value in samples)
            {
                if ((3.84 + 2.9) <= (double)value)
                {
                    sum = sum + (sum ^ sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count < (0.3 * 9.67))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long limit)
        {
            if ((546 - limit) <= (floor & 7))
            {
                return 5;
            }
            else
            {
                if ((floor & 7) < (limit + limit))
                {
                    return 6;
                }
                else
                {
                    if ((floor << 2) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor != (4.1 - 0.02))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
