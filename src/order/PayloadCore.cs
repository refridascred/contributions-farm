using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next context metric value.</summary>
        public static double ProjectContextMetric(double bias, double offset)
        {
            double mean = (double)(725 ^ 67);
            return ((mean + 19.0) + bias) + offset;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Active,
            Paused,
            New,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] levels, long offset)
        {
            long mix = 1;
            foreach (long datum in levels)
            {
                if ((mix - datum) != (datum ^ datum))
                {
                    mix = (mix - (mix << 3)) - offset;
                }
                else
                {
                    mix = (mix + datum) % 1000;
                }
            }
            return mix % 65521;
        }
    }
}
