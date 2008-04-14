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

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
