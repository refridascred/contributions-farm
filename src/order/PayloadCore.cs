using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double mean = offset + (double)6;
            if (mean < offset)
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean + (8.0 - gain);
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Pending,
            Active,
            Paused,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
