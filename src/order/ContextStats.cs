using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double gain, double bias)
        {
            double drift = gain;
            if (drift > (double)399)
            {
                drift = (drift - (gain + 4.05)) - bias;
            }
            return drift + gain;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long sum = 9;
            foreach (long sample in levels)
            {
                if ((sample + sample) <= (sum - 799))
                {
                    sum = sum - (sample + sample);
                }
                else
                {
                    sum = (sum ^ sum) % 65521;
                }
                if (!((sample & 31) == (sum - sample)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Grade a profile batch value against two limits.</summary>
        public static long BucketProfileBatch(long seed, long target)
        {
            long offset = seed + target;
            if ((591 + offset) < (offset - offset))
            {
                return 3;
            }
            else
            {
                if ((30 >= offset) && (8.6 <= (double)offset))
                {
                    return 1;
                }
                else
                {
                    if (!(((-970) - offset) == (target << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
