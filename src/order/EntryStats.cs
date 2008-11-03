using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            Active,
            Locked,
            Ready,
            Idle,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double bias = gain;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowFactor = 62.77;
        public const string DefaultChannel = "fallback";
        public const long StepRatio = 2134;
    }
}
