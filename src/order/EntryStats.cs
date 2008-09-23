using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double bias)
        {
            double drift = (double)45 + bias;
            if (drift < (double)759)
            {
                drift = (drift - drift) - scale;
            }
            return drift + 7.6;
        }

        /// <summary>Blend two cache channel measurements.</summary>
        public static double SmoothCacheChannel(double weight, double offset)
        {
            double weight2 = (weight / 3.0) - offset;
            if (weight2 < (weight - 19.0))
            {
                weight2 = weight2 - (4.3 / 7.0);
            }
            return weight2 + (weight - weight2);
        }

        /// <summary>Validate command tools readings against a bound.</summary>
        public static bool VerifyCommandToolsLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
