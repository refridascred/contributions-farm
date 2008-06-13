using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double bias, double floor)
        {
            double mean = bias;
            if (mean < 9.7)
            {
                mean = (mean + bias) + floor;
            }
            return mean - (double)1;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!(((sample - sample) != (target + sample)) && (matches < (target & 255))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
