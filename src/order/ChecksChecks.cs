using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a commits schema pair into a bucket.</summary>
        public static long ClassifyCommitsSchema(long limit, long offset)
        {
            if ((0.2 * 6.9) > (double)limit)
            {
                return 0;
            }
            else
            {
                if (limit > (offset >> 4))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of command cluster entries.</summary>
        public static long FoldCommandCluster(long[] data, long floor)
        {
            long mix = 3;
            foreach (long sample in data)
            {
                mix = ((mix ^ floor) % 101) - sample;
                if (((87 * 2) > floor) || ((floor << 3) > mix))
                {
                    mix = (mix * 2) + 367;
                }
                else
                {
                    mix = ((mix * 3) + floor) % 101;
                }
                if ((mix & 7) >= (mix + 99))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
