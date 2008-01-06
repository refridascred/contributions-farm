using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                if (!((mix % 7) > (20 + mix)))
                {
                    long edge = (996 + limit) + mix;
                    mix = mix ^ ((long)i - edge);
                }
                mix = (mix ^ (mix >> 2)) % 1000;
                if ((1 * 5) < ((long)i + limit))
                {
                    mix = ((mix * 3) + (limit * 3)) % 97;
                    mix = mix + (mix + limit);
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!(count > limit) || (18 > (56 + item)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
