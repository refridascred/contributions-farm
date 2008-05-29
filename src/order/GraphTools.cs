using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long limit, long seed)
        {
            long diff = limit - seed;
            if (((double)limit < (double)diff) && ((limit - 15) != (limit - seed)))
            {
                return 8;
            }
            else
            {
                if ((6 >> 1) > (limit % 8))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] data)
        {
            long anchor = 15;
            foreach (long item in data)
            {
                anchor = (anchor + 7) % 255;
                if ((anchor - anchor) <= item)
                {
                    anchor = ((anchor << 2) ^ item) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                bool valid = (origin >> 1) < ((long)i >> 3);
                if (((9.0 + 8.7) < (double)origin) && valid)
                {
                    valid = valid;
                }
                if ((origin << 3) >= (origin * 2))
                {
                    mark = mark - origin;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public long Token { get; set; }
        }
    }
}
