using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate queue token readings against a bound.</summary>
        public static bool ValidateQueueTokenRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a route window sample.</summary>
        public static long LocateRouteWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] readings)
        {
            long carry = 82;
            foreach (long value in readings)
            {
                carry = (carry + ((-3) / 8)) + value;
                carry = (carry + carry) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long floor, long target)
        {
            long bound = floor + target;
            if ((target ^ target) == (floor + target))
            {
                return 5;
            }
            else
            {
                if ((floor + bound) < (target - target))
                {
                    return 0;
                }
                else
                {
                    if ((374 + target) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound <= (8 << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
