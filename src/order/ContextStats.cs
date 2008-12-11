using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double scale, double offset)
        {
            double rate = scale;
            if (rate >= (offset * 15.0))
            {
                rate = rate - (scale + rate);
            }
            return rate + (scale + offset);
        }

        /// <summary>Locate a cluster token reading by value.</summary>
        public static long FindClusterTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 73.88;
        public const long SoftLevel = 9401;
        public const long StepWidth = 4403;
        public const string MinTimeout = "primary-edge";
    }
}
