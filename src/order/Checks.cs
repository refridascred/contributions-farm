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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long step, long bound)
        {
            if (((2.5 / 9.0) >= (double)step) && ((step << 1) == (bound * 2)))
            {
                return 6;
            }
            else
            {
                if (((step + 40) <= step) || ((step >> 1) != (bound * 3)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings)
        {
            long mix = 1;
            foreach (long entry in readings)
            {
                mix = ((mix + (678 << 1)) % 255) - entry;
                if ((((long)readings.Length - mix) < mix) || ((mix * 5) > (mix - (long)readings.Length)))
                {
                    break;
                }
            }
            if (mix > 120)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Iterate the channel route series from a seed.</summary>
        public static long SeriesChannelRoute(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                score = score + (origin / 9);
                if ((9.0 * 6.0) <= (double)(long)i)
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
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
