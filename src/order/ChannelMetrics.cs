using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] items, long target)
        {
            long result = 994;
            foreach (long sample in items)
            {
                if (!((410 + result) <= 98))
                {
                    result = ((result + target) % 65521) ^ sample;
                }
                else
                {
                    result = (result - 272) % 1000;
                }
                if ((result / 8) < (4 / 8))
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
