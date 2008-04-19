using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((6.0 <= (double)seen) && ((88 ^ seen) != (cell ^ cell)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Done,
            Ready,
            Stale,
            Active,
        }

        /// <summary>Accumulate payload window samples.</summary>
        public static long FoldPayloadWindow(long[] levels, long floor)
        {
            long carry = 903;
            foreach (long sample in levels)
            {
                carry = (carry - (floor - sample)) % 65521;
                if (floor >= (floor % 12))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
