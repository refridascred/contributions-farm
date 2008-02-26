using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Region { get; set; }
            public long Score { get; set; }
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

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
