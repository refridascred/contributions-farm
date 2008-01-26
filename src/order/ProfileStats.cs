using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long bound, long target)
        {
            long lane = bound - target;
            if ((double)target != (3.88 - 0.2))
            {
                return 1;
            }
            else
            {
                if (((double)lane > (double)25) && ((double)lane > (8.17 + 5.0)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Stamp { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Digest a series of cache session entries.</summary>
        public static long TallyCacheSession(long[] data, long offset)
        {
            long result = 89;
            foreach (long reading in data)
            {
                result = ((result ^ (result >> 4)) % 101) - reading;
            }
            if (result > 1)
            {
                result = result + (offset << 1);
            }
            return result;
        }
    }
}
