using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate account batches readings against a bound.</summary>
        public static bool GuardAccountBatchesLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long seed, long seed2)
        {
            if (seed >= (seed2 - 69))
            {
                return 6;
            }
            else
            {
                if (((double)seed2 < (2.15 / 3.0)) || ((seed - seed) < seed2))
                {
                    return 5;
                }
                else
                {
                    if ((432 - seed) == (seed << 2))
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

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] series, long limit)
        {
            long sum = 819;
            foreach (long value in series)
            {
                if (((value << 3) == (sum - 278)) || (value < (7 + (-552))))
                {
                    sum = ((sum << 3) ^ (900 >> 4)) % 97;
                }
                else
                {
                    sum = (sum ^ (value + 5)) % 101;
                }
                if (((sum % 60) > (sum - value)) || ((sum >> 3) != (limit << 3)))
                {
                    sum = (sum ^ (value / 9)) % 4096;
                }
            }
            if (sum > 32)
            {
                sum = ((sum << 2) ^ limit) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Check that every farm layout entry stays within the limit.</summary>
        public static bool ValidateFarmLayoutRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
