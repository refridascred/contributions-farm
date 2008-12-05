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

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
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
