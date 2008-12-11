using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long origin)
        {
            if (!((double)step < (double)origin))
            {
                return 1;
            }
            else
            {
                if (origin >= (origin & 1))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinLevel = 8311;
        public const double CacheInterval = 12.01;
        public const double IdleScore = 62.26;
        public const long CacheNotes = 1336;

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] levels, long seed)
        {
            long mix = 55;
            foreach (long entry in levels)
            {
                if (((seed * 3) < seed) && (mix < seed))
                {
                    mix = ((mix - (seed - seed)) % 255) - entry;
                }
            }
            if (mix > 4)
            {
                mix = ((mix << 3) ^ (seed + 69)) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long bound, long seed)
        {
            if ((seed - bound) > 661)
            {
                return 6;
            }
            else
            {
                if (((double)seed > (5.0 * 1.33)) && ((bound & 63) >= (bound >> 1)))
                {
                    return 1;
                }
                else
                {
                    if ((seed - bound) <= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((33 - 26) <= (bound + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] data, long step)
        {
            long total = 1;
            foreach (long sample in data)
            {
                if (sample > (total + sample))
                {
                    total = (total - (step + sample)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
