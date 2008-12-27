using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] values, long target)
        {
            long carry = 8;
            foreach (long datum in values)
            {
                if ((double)carry == (12.0 - 20.0))
                {
                    carry = ((carry * 2) + (carry + target)) % 4096;
                    carry = (carry + carry) % 101;
                    continue;
                }
                if (8 >= datum)
                {
                    carry = (carry ^ datum) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of buffer batch readings.</summary>
        public static long CompareBufferBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long origin, long offset)
        {
            if ((offset - 2) > (offset / 5))
            {
                return 5;
            }
            else
            {
                if (930 > (offset + origin))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 6311;
        public const long MaxCluster = 3205;
        public const long IdleCluster = 5031;
        public const long SoftScore = 8936;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (value < (count << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
