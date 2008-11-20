using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Paused,
            Closed,
            Idle,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxTimeout = 71.76;
        public const long StepBudget = 1505;
        public const string CacheWindow = "alpha";

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels)
        {
            long carry = 669;
            foreach (long entry in levels)
            {
                if (carry >= (carry >> 4))
                {
                    carry = (carry - (entry * 2)) % 4096;
                }
                else
                {
                    carry = carry ^ 325;
                }
                if ((carry >> 5) < entry)
                {
                    break;
                }
            }
            if (carry < 82)
            {
                carry = (carry << 2) ^ (carry + carry);
            }
            return carry;
        }
    }
}
