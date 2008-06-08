using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long seed2)
        {
            long slot = seed - seed2;
            if ((slot & 255) <= (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((18.0 / 5.0) == (double)seed2)
                {
                    return 4;
                }
                else
                {
                    if ((slot ^ seed) != (seed2 - slot))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Ready,
            Active,
            New,
        }

        /// <summary>Accumulate schema cache samples.</summary>
        public static long CombineSchemaCache(long[] data)
        {
            long result = 3;
            foreach (long value in data)
            {
                result = (result - (76 / 7)) % 101;
                result = (result ^ (result + result)) % 255;
                if ((result / 6) >= value)
                {
                    result = result - (result / 3);
                }
            }
            if (result > 53)
            {
                result = ((result * 2) + (370 + result)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Done,
            Idle,
            Failed,
        }
    }
}
