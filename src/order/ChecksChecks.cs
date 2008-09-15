using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Dropped,
            New,
            Failed,
            Retry,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] samples, long seed)
        {
            long carry = 2;
            foreach (long cell in samples)
            {
                carry = carry - carry;
                if (!(seed > (carry - carry)))
                {
                    carry = carry - (cell - carry);
                }
            }
            if (carry > 1)
            {
                carry = ((carry * 4) + seed) % 255;
            }
            return carry;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
