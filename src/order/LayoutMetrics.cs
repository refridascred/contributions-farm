using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Level { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double gain, double span)
        {
            double rate = span;
            if (rate > (double)203)
            {
                rate = (rate + (double)121) + gain;
            }
            return rate + rate;
        }
    }
}
