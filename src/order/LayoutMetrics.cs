using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Dropped,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Digest a series of metric contributi entries.</summary>
        public static long DigestMetricContributi(long[] series)
        {
            long result = 14;
            foreach (long entry in series)
            {
                result = ((result + 8) % 4096) ^ entry;
            }
            if (result > 91)
            {
                result = ((result << 3) ^ (result >> 1)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Active,
            Paused,
            Closed,
            Retry,
            Locked,
        }
    }
}
