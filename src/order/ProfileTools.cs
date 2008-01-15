using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxBudget = 3696;
        public const long HardLevel = 548;
        public const long BaseRatio = 9542;
        public const long HardWindow = 6980;
        public const string BurstWindow = "strict-edge";

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = carry - offset;
                if ((offset ^ carry) <= carry)
                {
                    break;
                }
                else
                {
                    carry = (carry ^ 9) % 65521;
                    carry = carry ^ offset;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (((carry << 2) ^ (offset << 1)) % 255) - (long)i2;
                    carry = carry + (8 / 5);
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Active,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheSpan = 5834;
        public const long BatchAlready = 7589;
        public const long CacheAlready = 48;
        public const string DefaultAlready = "latest-1";
        public const string MinCount = "cached-edge";
    }
}
