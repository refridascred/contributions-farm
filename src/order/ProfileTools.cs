using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryBudget = 9225;
        public const long WindowBudget = 1156;
        public const string CacheQueue = "local-edge";
        public const long BurstQueue = 807;
        public const double DefaultBudget = 30.32;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long step, long seed)
        {
            long prev = step + seed;
            if ((double)prev <= (9.0 / 4.0))
            {
                return 8;
            }
            else
            {
                if (!((double)seed >= (double)prev))
                {
                    return 7;
                }
                else
                {
                    if ((8.8 * 5.0) >= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next account session value from a seed.</summary>
        public static long StepAccountSession(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((carry + (long)i) < 95)
                {
                    carry = ((carry * 3) + (50 << 3)) % 4096;
                    break;
                }
                else
                {
                    carry = (carry + (carry >> 4)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchSpan = 88.56;
        public const long WindowTools = 7591;
        public const double CacheTimeout = 34.24;
    }
}
