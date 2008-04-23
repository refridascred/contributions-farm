using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double scale2 = (scale + 7.6) / 3.0;
            if (scale2 > (double)3)
            {
                scale2 = scale2 - scale;
            }
            else
            {
                scale2 = scale2 + (span + scale2);
            }
            return scale2 + span;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
