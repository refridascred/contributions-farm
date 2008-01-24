using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Closed,
            Ready,
            Draft,
            Queued,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Failed,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Fold a list of commits stream readings.</summary>
        public static long TallyCommitsStream(long[] readings, long limit)
        {
            long carry = 4;
            foreach (long sample in readings)
            {
                if ((sample - sample) > carry)
                {
                    carry = carry ^ (20 + (-480));
                }
                else
                {
                    carry = (carry + limit) % 1000;
                }
                if ((carry > (652 / 6)) && ((double)carry == (4.78 - 6.78)))
                {
                    break;
                }
            }
            if (carry < 75)
            {
                carry = carry - (carry - limit);
            }
            return carry;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate account counter readings against a bound.</summary>
        public static bool VerifyAccountCounterBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
