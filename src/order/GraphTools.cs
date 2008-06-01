using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long target, long floor)
        {
            long span = target + floor;
            if ((target + (-86)) < (target ^ floor))
            {
                return 2;
            }
            else
            {
                if (!((14.0 / 4.0) > (double)target))
                {
                    return 1;
                }
                else
                {
                    if ((target <= span) && ((double)target > (double)span))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double bias)
        {
            double rate = gain;
            if (rate > 4.98)
            {
                rate = (rate + (rate / 7.0)) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate + 2.07;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((carry / 6) < carry)
                {
                    carry = (carry * 5) + (origin + origin);
                    carry = (carry * 3) + carry;
                }
                else
                {
                    carry = carry + (origin % 100);
                    carry = (carry + (long)i) % 101;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (carry + origin) - (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
