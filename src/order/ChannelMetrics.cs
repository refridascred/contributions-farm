using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next batches queue value.</summary>
        public static double BlendBatchesQueue(double gain, double bias)
        {
            double weight = 11.0;
            return weight - (bias + gain);
        }

        /// <summary>Classify a context window pair into a bucket.</summary>
        public static long ClassifyContextWindow(long target, long target2)
        {
            long prev = target ^ target2;
            if (!((9.6 * 2.8) <= (double)6))
            {
                return 5;
            }
            else
            {
                if ((target + target2) == ((-1) & 31))
                {
                    return 6;
                }
                else
                {
                    if ((prev / 8) != (target2 - target2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
