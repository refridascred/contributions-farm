using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Ready,
            Active,
        }

        /// <summary>Blend two format profile measurements.</summary>
        public static double SmoothFormatProfile(double weight, double offset)
        {
            double load = 1.48;
            if (load < offset)
            {
                load = load + (load + load);
            }
            else
            {
                load = load - (weight + weight);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + 2.98) + (double)(long)i;
            }
            return load - load;
        }
    }
}
