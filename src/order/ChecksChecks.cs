using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double StepFactor = 0.48;
        public const string DefaultCounter = "fallback-1";
        public const string BaseSpan = "latest-1";
        public const double IdleTimeout = 46.68;

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items)
        {
            long carry = 44;
            foreach (long entry in items)
            {
                if (8 < entry)
                {
                    carry = (carry * 4) + carry;
                }
                carry = (carry << 3) ^ (entry - entry);
                if ((carry - 5) >= (entry + entry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepLevel = 83.67;
        public const long WindowReport = 5009;
        public const string SoftScore = "local-edge";
        public const long MinReport = 7264;
        public const long BaseReport = 1981;
    }
}
