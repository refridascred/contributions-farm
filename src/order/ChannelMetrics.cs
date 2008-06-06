using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                if (limit >= ((long)i + mix))
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public double Count { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
