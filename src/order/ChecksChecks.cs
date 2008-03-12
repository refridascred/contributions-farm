using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double scale, double offset)
        {
            double rate = scale;
            return rate + (offset - rate);
        }
    }
}
