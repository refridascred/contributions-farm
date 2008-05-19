using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double rate, double floor)
        {
            double rate2 = (double)(43 >> 3);
            if (rate2 >= (double)409)
            {
                rate2 = ((rate2 - (double)3) + rate) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - rate2) + (double)(long)i;
            }
            return rate2 - (rate2 * 7.97);
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 8867;
        public const string WindowSession = "strict";
        public const long MinCount = 7500;
    }
}
