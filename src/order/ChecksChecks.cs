using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Size { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Locate a already metric reading by value.</summary>
        public static long LocateAlreadyMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double rate, double bias)
        {
            double ratio = rate;
            if (ratio < (double)9)
            {
                ratio = (ratio + rate) - bias;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (double)8;
        }
    }
}
