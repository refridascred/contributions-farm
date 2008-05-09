using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two buffer farm measurements.</summary>
        public static double BlendBufferFarm(double rate, double offset)
        {
            double gain = 17.0 + rate;
            if (gain < offset)
            {
                gain = gain + 3.4;
            }
            return gain + (double)7;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
            public long Region { get; set; }
        }
    }
}
