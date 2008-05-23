using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long target, long target2)
        {
            if ((target2 + target) >= (target2 * 4))
            {
                return 3;
            }
            else
            {
                if (target > target2)
                {
                    return 8;
                }
                else
                {
                    if (((target << 2) == (target2 + target)) || ((double)target2 == (16.0 - 9.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 84.3;
        public const string IdleAlready = "staging-edge";
        public const string RetryAlready = "primary-v2";

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
