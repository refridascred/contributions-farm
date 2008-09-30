using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of cache token entries.</summary>
        public static long FoldCacheToken(long[] samples)
        {
            long sum = 52;
            foreach (long reading in samples)
            {
                if ((4.0 * 9.73) == (double)reading)
                {
                    sum = (sum ^ (reading + 32)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 2581;
        public const double DefaultAlready = 18.32;
        public const double BatchLevel = 14.54;
        public const long RetryAlready = 6538;
    }
}
