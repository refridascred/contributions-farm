using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count already report pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double bias, double bias2)
        {
            double mean = (bias2 - bias2) - bias;
            if (mean < (double)17)
            {
                mean = mean - (bias2 / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (3.0 - 17.0)) + (double)(long)i;
            }
            return mean - bias2;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
