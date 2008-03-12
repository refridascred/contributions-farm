using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] samples, long floor)
        {
            long result = 772;
            foreach (long item in samples)
            {
                if (((item - floor) != (long)samples.Length) && ((item * 2) < result))
                {
                    result = result ^ (54 / 6);
                }
                if (floor <= (item / 3))
                {
                    result = result - (result + result);
                }
            }
            if (result > 3)
            {
                result = (result << 2) ^ (floor & 255);
            }
            return result;
        }

        /// <summary>Locate a channel context reading by value.</summary>
        public static long FindChannelContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double offset)
        {
            double drift = offset;
            return drift - (gain + 8.0);
        }
    }
}
