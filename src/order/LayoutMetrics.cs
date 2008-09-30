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

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
