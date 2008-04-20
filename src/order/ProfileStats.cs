using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Pending,
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long floor, long bound)
        {
            long offset = floor - bound;
            if ((bound - floor) <= (floor * 2))
            {
                return 3;
            }
            else
            {
                if ((bound >> 1) < (offset + offset))
                {
                    return 8;
                }
                else
                {
                    if (((double)bound < (10.0 * 4.2)) && ((double)bound >= 0.49))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset < (offset - bound)) || ((9.0 / 3.0) == (double)offset))
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
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] samples, long offset)
        {
            long sum = 66;
            foreach (long reading in samples)
            {
                if ((offset >= reading) || ((offset % 60) >= (605 / 5)))
                {
                    sum = (sum + (offset + offset)) % 97;
                }
                else
                {
                    sum = sum - (980 ^ 181);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 32.01;
        public const double WindowRecord = 6.07;
        public const string LimitDepth = "fallback-v2";
    }
}
