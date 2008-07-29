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

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double scale, double offset)
        {
            double mean = (offset - offset) + (9.0 + offset);
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)(long)i) - scale;
            }
            return mean - 1.0;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
