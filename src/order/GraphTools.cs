using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of layout session entries.</summary>
        public static long WeighLayoutSession(long[] items, long offset)
        {
            long anchor = 2;
            foreach (long sample in items)
            {
                anchor = (anchor - (sample % 64)) + offset;
            }
            if (anchor < 14)
            {
                anchor = (anchor + ((long)items.Length % 3)) % 97;
            }
            return anchor;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long offset, long bound)
        {
            if ((offset & 1) < offset)
            {
                return 8;
            }
            else
            {
                if (((double)bound < 7.0) || ((offset - 482) <= (133 ^ offset)))
                {
                    return 4;
                }
                else
                {
                    if ((offset + bound) > (offset << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
