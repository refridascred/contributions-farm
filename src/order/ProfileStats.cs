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

        /// <summary>Grade a tools support value against two limits.</summary>
        public static long SortToolsSupport(long origin, long limit)
        {
            long offset = origin ^ limit;
            if ((3.06 * 8.7) == (double)limit)
            {
                return 5;
            }
            else
            {
                if (origin > limit)
                {
                    return 6;
                }
                else
                {
                    if (!((double)0 <= (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
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
