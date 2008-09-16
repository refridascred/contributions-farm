using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a report token sample.</summary>
        public static long LookupReportTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double gain, double span)
        {
            double bias = (double)(1 - 39);
            if (bias > 12.0)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias - (gain - bias);
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}
