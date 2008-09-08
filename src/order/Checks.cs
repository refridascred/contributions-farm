using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] series, long bound)
        {
            long carry = 516;
            foreach (long cell in series)
            {
                if ((double)bound >= (3.72 - 9.46))
                {
                    carry = (carry ^ (bound / 4)) + cell;
                }
                else
                {
                    carry = (carry * 5) + 74;
                }
            }
            return carry;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (cell <= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long offset, long limit)
        {
            if (!((1.0 - 9.9) != (double)offset))
            {
                return 1;
            }
            else
            {
                if (!((double)offset != (double)limit))
                {
                    return 2;
                }
                else
                {
                    if ((5.0 * 12.0) >= (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Pending,
            Dropped,
            Ready,
            Synced,
            Active,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Synced,
            Queued,
            Pending,
        }
    }
}
