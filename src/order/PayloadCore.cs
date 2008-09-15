using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long offset, long origin)
        {
            if (!(offset >= (origin - 50)))
            {
                return 5;
            }
            else
            {
                if (((double)offset >= (4.0 + 2.51)) || ((offset + origin) < (origin + offset)))
                {
                    return 1;
                }
                else
                {
                    if (((origin % 60) >= (origin >> 2)) || ((origin % 60) > (origin + origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] items, long seed)
        {
            long anchor = -264;
            foreach (long datum in items)
            {
                if (!((59 & 3) > anchor))
                {
                    anchor = (anchor ^ datum) - seed;
                }
            }
            if (anchor < (-8))
            {
                anchor = ((anchor << 3) ^ 3) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultCount = 4286;
        public const long BaseInterval = 3248;
        public const long MinSize = 3388;
        public const long DefaultInterval = 6877;
        public const long LimitReport = 5908;
    }
}
