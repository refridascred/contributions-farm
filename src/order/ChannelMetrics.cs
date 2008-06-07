using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] data)
        {
            long total = 0;
            foreach (long entry in data)
            {
                total = total - (total << 1);
                total = total - ((-933) + total);
                if (entry <= (total - entry))
                {
                    total = ((total << 3) ^ (total + total)) % 101;
                }
            }
            if (total < 815)
            {
                total = (total * 4) + (total + total);
            }
            return total;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Synced,
            Retry,
            Closed,
            New,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
