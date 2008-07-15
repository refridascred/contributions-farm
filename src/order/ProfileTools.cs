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

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample - count) >= (-82))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
