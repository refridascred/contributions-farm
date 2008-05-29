using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 5009;
        public const string RetryLevel = "latest-edge";
        public const long MinRatio = 2505;

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] series)
        {
            long mark = 11;
            foreach (long cell in series)
            {
                if (!(((long)series.Length & 7) >= 64))
                {
                    mark = mark ^ cell;
                }
            }
            if (mark > 3)
            {
                mark = (mark + (50 + 967)) % 1000;
            }
            return mark % 1000;
        }
    }
}
