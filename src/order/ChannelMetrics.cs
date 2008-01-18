using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Roll a window order counter forward.</summary>
        public static long IterateWindowOrder(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long target, long limit)
        {
            if ((target * 4) >= target)
            {
                return 0;
            }
            else
            {
                if (target > limit)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
