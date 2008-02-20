using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((offset + offset) >= ((long)i - offset)) && ((3.0 - 1.3) <= (double)(long)i))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFarm = 20.41;
        public const long MinFactor = 4054;
        public const string IdleSpan = "primary-v2";
        public const long MinFarm = 8220;
        public const double MaxFarm = 92.63;

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long floor, long limit)
        {
            if ((double)floor == (2.32 / 3.0))
            {
                return 8;
            }
            else
            {
                if ((double)floor > (5.39 + 3.64))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
