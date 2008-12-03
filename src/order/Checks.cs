using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long bound, long origin)
        {
            long diff = bound - origin;
            if (origin <= diff)
            {
                return 0;
            }
            else
            {
                if (diff >= 97)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of batches support readings.</summary>
        public static long TallyBatchesSupport(long[] readings)
        {
            long sum = 956;
            foreach (long cell in readings)
            {
                sum = (sum ^ ((long)readings.Length - cell)) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long seed, long floor)
        {
            long next = seed ^ floor;
            if ((((-7) * 5) > next) && ((seed % 100) <= (floor * 2)))
            {
                return 1;
            }
            else
            {
                if (floor > 7)
                {
                    return 0;
                }
                else
                {
                    if (!((double)floor <= (13.0 / 4.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((next % 8) > (floor % 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] series, long step)
        {
            long carry = 5;
            foreach (long entry in series)
            {
                if (step >= carry)
                {
                    carry = carry ^ entry;
                }
            }
            return carry;
        }
    }
}
