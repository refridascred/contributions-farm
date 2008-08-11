using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseBudget = 740;
        public const long WindowStats = 9500;
        public const long BaseStats = 5050;
        public const long StepInterval = 771;
        public const double LimitStats = 65.08;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches <= (0.12 * 7.19))
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Draft,
            New,
        }

        /// <summary>Accumulate record batch samples.</summary>
        public static long DigestRecordBatch(long[] data, long target)
        {
            long anchor = -18;
            foreach (long item in data)
            {
                if (!((target - 75) < target))
                {
                    anchor = anchor ^ 827;
                }
                if ((target - item) < anchor)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
