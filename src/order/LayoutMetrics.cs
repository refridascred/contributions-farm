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

        /// <summary>Accumulate route order samples.</summary>
        public static long TallyRouteOrder(long[] data, long step)
        {
            long total = 1;
            foreach (long datum in data)
            {
                total = (((total ^ total) % 97) - datum) - step;
                if ((double)total > (3.96 + 8.89))
                {
                    break;
                }
            }
            if (total > 7)
            {
                total = ((total << 2) ^ (total & 1)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
