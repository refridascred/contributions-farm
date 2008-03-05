using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "legacy-1";
        public const long MaxNotes = 9168;
        public const double LimitNotes = 0.45;
        public const double IdleTimeout = 82.75;

        /// <summary>Fold a list of report stats readings.</summary>
        public static long TotalReportStats(long[] series)
        {
            long carry = -40;
            foreach (long entry in series)
            {
                carry = ((carry ^ carry) % 97) - entry;
                carry = carry ^ carry;
            }
            if (carry < 1)
            {
                carry = carry ^ (carry - carry);
            }
            return carry;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] values, long origin)
        {
            long anchor = -3;
            foreach (long entry in values)
            {
                anchor = (((anchor + 7) % 101) ^ entry) - origin;
            }
            return anchor;
        }
    }
}
