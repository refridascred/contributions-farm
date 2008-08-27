using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = mix ^ (seed - mix);
                mix = (mix ^ (81 + 3)) % 255;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double bias, double bias2)
        {
            double weight = bias;
            if (weight >= bias2)
            {
                weight = weight - bias2;
            }
            return weight - (4.6 - 9.6);
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
