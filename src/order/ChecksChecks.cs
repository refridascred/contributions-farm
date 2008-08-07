using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double gain, double bias)
        {
            double drift = bias;
            if (drift > 18.0)
            {
                drift = (drift - (drift * 8.07)) - gain;
            }
            else
            {
                drift = drift - (drift + bias);
            }
            return drift - (drift - drift);
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double weight, double offset)
        {
            double bias = offset / 9.0;
            return bias + (bias - weight);
        }
    }
}
