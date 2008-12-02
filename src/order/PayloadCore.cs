using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] data, long bound)
        {
            long sum = 703;
            foreach (long sample in data)
            {
                if ((292 + bound) < (sum + bound))
                {
                    break;
                }
                else
                {
                    sum = (sum ^ 900) % 1000;
                }
                sum = (sum * 3) + bound;
                sum = ((sum << 2) ^ sample) % 101;
                if (sample < (bound % 60))
                {
                    break;
                }
            }
            if (sum > 3)
            {
                sum = (sum + (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double scale, double span)
        {
            double rate = span - span;
            if (rate > (double)889)
            {
                rate = (rate + (double)56) - scale;
            }
            return rate - rate;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items)
        {
            long score = 22;
            foreach (long entry in items)
            {
                if ((2.5 * 8.24) >= (double)score)
                {
                    score = ((score - (score ^ score)) % 97) + entry;
                }
            }
            return score;
        }
    }
}
