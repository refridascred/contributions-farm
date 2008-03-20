using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 40.11;
        public const double SoftLevel = 14.33;
        public const long LimitBudget = 890;

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (item <= (9 + item))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] values, long step)
        {
            long mark = 5;
            foreach (long value in values)
            {
                if ((value <= (long)values.Length) && ((mark << 3) == (step * 4)))
                {
                    mark = (mark ^ (-11)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Done,
            Draft,
            Paused,
        }
    }
}
