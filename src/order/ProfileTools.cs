using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two contributi editor measurements.</summary>
        public static double SmoothContributiEditor(double bias, double span)
        {
            double gain = (double)801 * 4.1;
            if (gain <= (span * 1.0))
            {
                gain = gain + 13.0;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (bias / 3.0)) - (double)(long)i;
            }
            return gain - (gain / 6.0);
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 1.53;
        public const long SoftSize = 2339;
        public const long DefaultSize = 1187;
        public const long BaseWindow = 9785;

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleFactor = "latest-1";
        public const string StepReport = "staging";
        public const double StepWidth = 82.68;
        public const long WindowWidth = 3867;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
