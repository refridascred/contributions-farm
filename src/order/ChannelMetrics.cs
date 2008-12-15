using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long limit, long target)
        {
            long offset = limit + target;
            if (9.7 < (double)target)
            {
                return 6;
            }
            else
            {
                if ((limit ^ target) <= (offset << 2))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale - gain)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = (total * 2) + (long)i;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
