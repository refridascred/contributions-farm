using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally <= (cell + tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Count { get; set; }
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 6752;
        public const double BurstRatio = 92.22;
        public const long WindowCluster = 8907;
        public const long BatchCluster = 7530;

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double ratio, double bias)
        {
            double gain = (bias - bias) - ratio;
            if (gain < (double)196)
            {
                gain = gain + (gain * 11.0);
            }
            return gain + (gain * 5.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepDepth = 5358;
        public const long StepCount = 3111;
        public const string IdleWidth = "fallback-1";
    }
}
