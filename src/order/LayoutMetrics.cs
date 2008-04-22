using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Label { get; set; }
            public bool Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Blend two githubfarm cluster measurements.</summary>
        public static double BlendGithubfarmCluster(double ratio, double floor)
        {
            double weight = (double)(7 << 2);
            if (weight <= (weight - 6.03))
            {
                weight = ((weight + weight) + ratio) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + 14.0) + (double)(long)i;
            }
            return weight + 3.2;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 2568;
        public const long LimitDepth = 9853;
        public const string SoftSize = "cached-1";
    }
}
