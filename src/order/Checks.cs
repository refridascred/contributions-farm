using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepCount = 9374;
        public const long CacheCount = 6932;
        public const double IdleWidth = 67.51;
        public const long HardWidth = 6560;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double rate, double span)
        {
            double weight = 2.22 - (double)66;
            if (weight > 9.25)
            {
                weight = (weight - (weight - weight)) + rate;
            }
            else
            {
                weight = weight - (span + weight);
            }
            return weight + (span - 6.45);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseEntry = 90.28;
        public const double BaseDepth = 21.08;
        public const long WindowScore = 154;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Active,
            Dropped,
            Paused,
        }
    }
}
