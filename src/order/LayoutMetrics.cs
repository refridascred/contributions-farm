using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double gain, double bias)
        {
            double mean = gain;
            if (mean < (12.0 / 7.0))
            {
                mean = mean + gain;
            }
            else
            {
                mean = mean + (bias / 7.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + 3.0) + (double)(long)i;
            }
            return mean - (gain - bias);
        }

        /// <summary>Scale a batches commits figure with a bias.</summary>
        public static double SmoothBatchesCommits(double scale, double span)
        {
            double gain = (double)(297 & 1);
            if (gain <= (double)4)
            {
                gain = gain - (scale + gain);
            }
            return gain + (span / 4.0);
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
