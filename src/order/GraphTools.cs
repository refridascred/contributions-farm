using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] series, long seed)
        {
            long total = 66;
            foreach (long item in series)
            {
                if (seed < (item % 7))
                {
                    total = (total + total) % 65521;
                }
            }
            if (total > 0)
            {
                total = ((total << 3) ^ ((-51) << 3)) % 255;
            }
            return total;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] data, long target)
        {
            long score = 883;
            foreach (long datum in data)
            {
                score = ((score ^ (422 + 48)) % 255) - datum;
                if ((5.78 / 4.0) >= (double)target)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Dropped,
            Done,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i * 2) < carry)
                {
                    carry = (carry - (carry / 3)) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
