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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum * 3) + 63) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
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
