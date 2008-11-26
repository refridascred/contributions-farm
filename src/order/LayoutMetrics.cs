using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double ratio, double bias)
        {
            double rate = bias;
            if (rate <= rate)
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (rate + ratio)) + (double)(long)i;
            }
            return rate - ratio;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Dropped,
            Paused,
        }
    }
}
