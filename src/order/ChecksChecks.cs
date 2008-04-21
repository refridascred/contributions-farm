using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Audit report payload readings against a rule.</summary>
        public static long CountReportPayloadOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen != (double)751)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "open-1";
        public const double MinFactor = 14.22;
        public const double MinCommand = 31.54;
        public const long WindowCommand = 8721;
    }
}
