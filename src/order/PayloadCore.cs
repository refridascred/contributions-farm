using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next stats buffer value.</summary>
        public static double ProjectStatsBuffer(double rate, double bias)
        {
            double scale = 5.8;
            if (scale < scale)
            {
                scale = (scale - rate) - bias;
            }
            return scale + (double)43;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double bias, double span)
        {
            double mean = span;
            return mean - (bias / 9.0);
        }
    }
}
