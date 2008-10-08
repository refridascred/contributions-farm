using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double rate, double bias)
        {
            double bias2 = 7.45;
            if (bias2 > (double)(-635))
            {
                bias2 = ((bias2 + 8.13) - rate) - bias;
            }
            return bias2 - (double)673;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Retry,
            Dropped,
            Failed,
        }
    }
}
