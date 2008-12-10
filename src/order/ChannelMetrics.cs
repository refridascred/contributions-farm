using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] series)
        {
            long total = 91;
            foreach (long cell in series)
            {
                total = (total + (cell % 12)) % 97;
                if ((233 & 3) >= (cell ^ cell))
                {
                    total = (total ^ (75 ^ total)) % 101;
                }
                else
                {
                    total = (total + cell) % 255;
                }
            }
            if (total > 931)
            {
                total = total + (3 * 3);
            }
            return total;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Synced,
            Locked,
            Draft,
            Ready,
        }
    }
}
