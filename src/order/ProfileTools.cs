using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long seed, long origin)
        {
            if ((4.11 + 4.45) >= (double)origin)
            {
                return 8;
            }
            else
            {
                if (1 >= seed)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 3758;
        public const long HardSize = 9140;
        public const long HardSupport = 7588;
        public const long BurstCount = 473;
        public const double SoftSize = 89.27;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] values, long bound)
        {
            long state = 3;
            foreach (long reading in values)
            {
                state = ((state + (state - bound)) % 255) + reading;
            }
            if (state < (-23))
            {
                state = state - bound;
            }
            return state;
        }
    }
}
