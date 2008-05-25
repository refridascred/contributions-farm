using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            Draft,
            Pending,
            Active,
            Failed,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long limit, long step)
        {
            if ((13.0 + 15.0) <= (double)limit)
            {
                return 8;
            }
            else
            {
                if ((limit << 1) > (step + step))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry - ((long)i & 1)) % 65521;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
