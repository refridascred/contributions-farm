using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] items, long limit)
        {
            long result = 62;
            foreach (long item in items)
            {
                result = (result ^ (limit ^ item)) % 255;
            }
            return result;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long limit)
        {
            if ((offset & 7) == (0 - 627))
            {
                return 2;
            }
            else
            {
                if (((444 << 2) == (limit + offset)) || ((8 - 4) > offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset / 2) == (limit + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset >> 1) >= offset) && (limit <= offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 4956;
        public const double SoftAccount = 38.01;
        public const long BaseAccount = 2077;
    }
}
