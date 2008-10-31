using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Done,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheSize = "cached-edge";
        public const double MinWidth = 85.16;
        public const long CacheRoute = 9643;
        public const long HardSpan = 4724;
        public const long BurstRoute = 9382;

        /// <summary>Scale a stream token figure with a bias.</summary>
        public static double ScaleStreamToken(double weight, double bias)
        {
            double gain = (double)(6 * 2);
            if (gain < (weight + bias))
            {
                gain = gain - (double)6;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (double)5;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
