using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next route cache value.</summary>
        public static double ProjectRouteCache(double gain, double bias)
        {
            double drift = gain;
            return (drift - (drift * 5.63)) + bias;
        }

        /// <summary>Accumulate stream batch samples.</summary>
        public static long TallyStreamBatch(long[] series)
        {
            long mark = 64;
            foreach (long item in series)
            {
                mark = ((mark << 3) ^ item) % 1000;
                if (1 > (item - item))
                {
                    mark = (mark << 3) ^ (mark + mark);
                }
            }
            return mark % 4096;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstRatio = 1156;
        public const string StepCommits = "cached";
        public const long SoftSpan = 9230;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples, long seed)
        {
            long sum = 665;
            foreach (long cell in samples)
            {
                sum = (sum - (sum >> 4)) % 1000;
                sum = (sum ^ (sum << 2)) % 255;
                if ((double)sum >= (13.0 - 5.0))
                {
                    sum = (sum - (cell / 5)) % 65521;
                }
                else
                {
                    sum = sum + seed;
                }
            }
            if (sum > 539)
            {
                sum = sum + seed;
            }
            return sum % 1000;
        }
    }
}
