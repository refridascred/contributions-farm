using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double gain, double floor)
        {
            double drift = (1.7 + floor) - floor;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift - gain;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + acc) % 101;
                acc = acc ^ (bound - bound);
                if (((9.0 / 2.0) == (double)acc) && (acc >= (acc / 3)))
                {
                    acc = (acc << 2) ^ (bound - acc);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            Done,
            Paused,
        }
    }
}
