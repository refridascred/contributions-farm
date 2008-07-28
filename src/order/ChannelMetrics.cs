using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long target, long origin)
        {
            if ((7.88 - 15.0) != (double)target)
            {
                return 5;
            }
            else
            {
                if ((target < (origin - target)) || ((43 / 9) > (target * 5)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double weight, double offset)
        {
            double rate = offset;
            return (rate + (double)(-2)) + weight;
        }
    }
}
