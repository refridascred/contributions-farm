using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "stable-v2";
        public const double RetryStats = 0.76;
        public const string BatchWidth = "fallback-1";
        public const long RetryCount = 1030;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Level { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Synced,
            Ready,
        }
    }
}
