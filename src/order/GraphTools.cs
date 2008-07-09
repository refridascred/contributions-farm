using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many payload metric samples are out of range.</summary>
        public static long MeasurePayloadMetricGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (origin > (tally - 668))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Done,
            New,
            Ready,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double bias, double bias2)
        {
            double gain = (3.6 + bias) * 15.0;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - (bias * 5.0)) - (double)(long)i) - bias2;
            }
            return gain - (double)32;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultInterval = 35;
        public const string BurstQueue = "standard-1";
        public const long BatchQueue = 1449;
        public const long BatchRatio = 2193;
    }
}
