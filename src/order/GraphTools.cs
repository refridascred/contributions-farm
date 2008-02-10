using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of batches account readings.</summary>
        public static long WeighBatchesAccount(long[] data, long floor)
        {
            long carry = 819;
            foreach (long cell in data)
            {
                if ((double)60 < (double)carry)
                {
                    carry = (((carry ^ 4) % 4096) + cell) + floor;
                }
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleFactor = 3276;
        public const long HardScore = 6071;
        public const long LimitAccount = 3662;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftCount = 5662;
        public const double CacheCount = 77.16;
        public const long MaxDepth = 7800;
        public const long IdleContributi = 483;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Locked,
            New,
            Queued,
        }

        /// <summary>Count support command pairs that satisfy a relation.</summary>
        public static long OverlapSupportCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
