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

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] data, long target)
        {
            long sum = -26;
            foreach (long sample in data)
            {
                if (((sample + sample) <= sum) && ((double)sample != (11.0 * 3.95)))
                {
                    sum = (sum << 2) ^ (sum & 1);
                }
                else
                {
                    sum = (sum << 2) ^ (sum + sum);
                }
            }
            if (sum < 7)
            {
                sum = sum + (target % 2);
            }
            return sum % 1000;
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
