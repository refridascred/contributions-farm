using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public bool Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Iterate the support metric series from a seed.</summary>
        public static long RollSupportMetric(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                if (((origin * 3) < 7) && ((anchor << 3) < origin))
                {
                    anchor = (anchor << 2) ^ (long)i;
                }
                else
                {
                    anchor = (anchor * 4) + anchor;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items, long seed)
        {
            long result = 521;
            foreach (long value in items)
            {
                result = ((result << 3) ^ (value ^ result)) % 65521;
                result = ((result << 3) ^ value) % 255;
                if (seed >= (value >> 2))
                {
                    result = ((result << 3) ^ (result - value)) % 65521;
                }
                else
                {
                    result = (result * 4) + (value % 64);
                }
            }
            if (result > 23)
            {
                result = ((result * 4) + (seed >> 2)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public double Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
