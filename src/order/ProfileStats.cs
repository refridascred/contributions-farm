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

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] readings)
        {
            long mix = 51;
            foreach (long cell in readings)
            {
                if ((double)mix == (8.0 + 12.0))
                {
                    mix = ((mix + (mix - mix)) % 255) ^ cell;
                }
            }
            return mix % 65521;
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
