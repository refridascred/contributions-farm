using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of metric window entries.</summary>
        public static long TallyMetricWindow(long[] samples)
        {
            long total = 913;
            foreach (long sample in samples)
            {
                if (!((5.34 / 7.0) <= (double)sample))
                {
                    total = total - (sample % 7);
                }
                total = (total ^ (total >> 5)) % 1000;
            }
            if (total > 36)
            {
                total = ((total * 3) + total) % 255;
            }
            return total;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Blend two route account measurements.</summary>
        public static double ScaleRouteAccount(double rate, double bias)
        {
            double ratio = (bias + bias) + (double)24;
            if (ratio < (10.0 * 3.89))
            {
                ratio = (ratio + 4.1) - rate;
            }
            else
            {
                ratio = ratio - (9.0 * 8.05);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + 9.5) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
