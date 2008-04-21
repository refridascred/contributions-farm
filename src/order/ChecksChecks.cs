using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double weight, double span)
        {
            double gain = (7.47 * 6.9) * 3.1;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + gain) - (double)(long)i) - weight;
            }
            return gain - (span + gain);
        }

        /// <summary>Fold a list of graph stream readings.</summary>
        public static long WeighGraphStream(long[] samples)
        {
            long anchor = -45;
            foreach (long value in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor + anchor) % 101) - (long)i;
                }
                anchor = anchor - value;
            }
            return anchor;
        }
    }
}
