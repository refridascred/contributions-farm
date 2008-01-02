using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double bias, double span)
        {
            double rate = span;
            if (rate < (span - span))
            {
                rate = rate + (double)44;
            }
            else
            {
                rate = rate + (5.0 / 9.0);
            }
            return rate + bias;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] series, long limit)
        {
            long carry = 56;
            foreach (long entry in series)
            {
                if (((1.0 + 16.0) > (double)entry) || ((entry - entry) > (carry + limit)))
                {
                    carry = carry + (carry ^ 6);
                }
            }
            if (carry > 6)
            {
                carry = ((carry << 3) ^ (230 - limit)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((double)(long)i != (17.0 + 12.0))
                {
                    sum = (sum - (sum & 3)) % 101;
                    sum = (sum - (floor + (long)i)) % 65521;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
