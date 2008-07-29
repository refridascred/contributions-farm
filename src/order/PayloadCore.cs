using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double rate, double offset)
        {
            double scale = (double)(5 - 23);
            if (scale > offset)
            {
                scale = (scale + (scale / 4.0)) - rate;
            }
            return scale - 4.8;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
