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

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Total { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
