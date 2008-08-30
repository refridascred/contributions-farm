using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] samples, long limit)
        {
            long mix = 7;
            foreach (long entry in samples)
            {
                if (((entry ^ mix) != ((long)samples.Length ^ limit)) || ((entry / 2) == (19 + mix)))
                {
                    mix = mix - entry;
                }
                else
                {
                    mix = (mix - (entry % 8)) % 101;
                }
            }
            if (mix < 5)
            {
                mix = (mix << 2) ^ limit;
            }
            return mix;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitSize = 28.71;
        public const double LimitRatio = 84.78;
        public const double WindowMetrics = 32.72;
    }
}
