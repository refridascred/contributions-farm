using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double gain, double span)
        {
            double ratio = (7.19 * 3.34) - (span - span);
            if (ratio < (double)87)
            {
                ratio = ratio + (ratio / 6.0);
            }
            else
            {
                ratio = ratio - (gain - ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - 6.8;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
