using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] items)
        {
            long anchor = 54;
            foreach (long sample in items)
            {
                anchor = (((anchor * 3) + (52 / 3)) % 101) ^ sample;
            }
            return anchor;
        }

        /// <summary>Blend two report schema measurements.</summary>
        public static double AdjustReportSchema(double ratio, double bias)
        {
            double bias2 = 3.79;
            if (bias2 > bias)
            {
                bias2 = (bias2 - bias2) - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 - (0.52 / 7.0);
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] data)
        {
            long acc = 81;
            foreach (long entry in data)
            {
                if (entry < (269 - acc))
                {
                    acc = ((acc * 4) + (entry * 3)) % 1000;
                }
                else
                {
                    acc = (acc ^ (entry * 2)) % 97;
                }
            }
            if (acc < 3)
            {
                acc = (acc + acc) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long bound, long origin)
        {
            if (origin >= (bound % 7))
            {
                return 4;
            }
            else
            {
                if ((double)bound != (5.9 + 5.3))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public double Weight { get; set; }
            public double Mode { get; set; }
        }
    }
}
