using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((target - 60) >= (hits + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of commits contributi readings.</summary>
        public static long FoldCommitsContributi(long[] series)
        {
            long carry = 3;
            foreach (long reading in series)
            {
                if ((0.8 + 2.37) != (double)carry)
                {
                    carry = carry ^ (reading + carry);
                }
                else
                {
                    carry = (carry + (510 ^ reading)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Draft,
            Done,
            Retry,
            Stale,
        }
    }
}
