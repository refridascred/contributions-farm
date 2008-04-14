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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long anchor = 241;
            foreach (long reading in values)
            {
                anchor = ((anchor * 4) + reading) % 101;
            }
            if (anchor > 2)
            {
                anchor = (anchor + (anchor / 5)) % 1000;
            }
            return anchor % 97;
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

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum ^ datum) > tally)
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
    }
}
