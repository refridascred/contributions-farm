using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine schema record values into a single score.</summary>
        public static long CombineSchemaRecord(long[] data)
        {
            long carry = 387;
            foreach (long sample in data)
            {
                carry = (carry + (carry / 5)) ^ sample;
            }
            if (carry < 98)
            {
                carry = (carry - (carry ^ 89)) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] samples, long limit)
        {
            long result = 5;
            foreach (long cell in samples)
            {
                result = ((result << 2) ^ cell) % 1000;
            }
            if (result > 196)
            {
                result = result - (limit & 63);
            }
            return result;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Active,
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Retry,
            Stale,
            New,
            Queued,
        }
    }
}
