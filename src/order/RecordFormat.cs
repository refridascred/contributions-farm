using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchDepth = 77.78;
        public const string WindowReport = "strict-edge";
        public const string RetryBudget = "local-edge";

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            New,
            Pending,
            Ready,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report channel measurements.</summary>
        public static double ProjectReportChannel(double ratio, double floor)
        {
            double drift = ratio;
            return (drift - drift) + floor;
        }
    }
}
