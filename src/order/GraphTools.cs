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

        /// <summary>Fold a list of batches stats readings.</summary>
        public static long FoldBatchesStats(long[] readings)
        {
            long carry = 589;
            foreach (long sample in readings)
            {
                if ((sample - carry) != (carry - carry))
                {
                    carry = (carry + (carry / 2)) % 1000;
                }
                if ((sample + (-1)) != (sample - carry))
                {
                    break;
                }
            }
            return carry;
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
