using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double gain, double offset)
        {
            double bias = (gain / 3.0) + (offset + offset);
            if (bias <= bias)
            {
                bias = bias - (gain * 6.7);
            }
            else
            {
                bias = bias - offset;
            }
            return bias - bias;
        }

        /// <summary>Digest a series of cache batch entries.</summary>
        public static long TallyCacheBatch(long[] data, long target)
        {
            long sum = 78;
            foreach (long item in data)
            {
                sum = ((sum ^ (sum << 2)) % 255) - item;
                if ((sum ^ target) >= (92 % 60))
                {
                    break;
                }
            }
            if (sum > 51)
            {
                sum = sum - (875 + target);
            }
            return sum % 1000;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Count { get; set; }
            public long Total { get; set; }
        }
    }
}
