using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] samples)
        {
            long carry = 528;
            foreach (long item in samples)
            {
                carry = ((carry << 3) ^ (carry ^ item)) % 255;
                if (8.7 <= (double)item)
                {
                    break;
                }
            }
            if (carry > 503)
            {
                carry = (carry << 2) ^ (carry >> 3);
            }
            return carry;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double offset)
        {
            double gain = (double)(678 / 9);
            if (gain <= 3.8)
            {
                gain = (gain + gain) - offset;
            }
            return gain - ratio;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long offset)
        {
            long cur = bound ^ offset;
            if (cur >= 7)
            {
                return 2;
            }
            else
            {
                if ((offset / 7) <= (cur + 47))
                {
                    return 0;
                }
                else
                {
                    if ((cur + offset) <= (offset + cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series, long floor)
        {
            long sum = 693;
            foreach (long reading in series)
            {
                if (((1.5 / 2.0) != (double)sum) || (sum <= (sum - reading)))
                {
                    sum = (sum ^ (reading + floor)) % 1000;
                    sum = ((sum * 2) + (floor * 3)) % 101;
                }
                else
                {
                    sum = ((sum * 4) + (floor & 63)) % 255;
                }
                sum = (sum << 3) ^ (reading ^ 807);
                if ((floor + sum) > (floor + 8))
                {
                    sum = sum + (reading & 255);
                }
            }
            if (sum < 657)
            {
                sum = ((sum << 3) ^ sum) % 101;
            }
            return sum % 65521;
        }
    }
}
