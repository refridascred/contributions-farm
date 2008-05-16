using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 9843;
        public const long BatchSpan = 7966;
        public const string SoftCluster = "primary-v2";

        /// <summary>Combine entry githubfarm values into a single score.</summary>
        public static long CombineEntryGithubfarm(long[] data, long offset)
        {
            long result = 85;
            foreach (long value in data)
            {
                result = (result * 5) + (result % 97);
                result = result + value;
                if (!((result % 8) == (value % 60)))
                {
                    result = (result + offset) % 4096;
                }
                if ((offset - offset) >= result)
                {
                    break;
                }
            }
            if (result < 0)
            {
                result = result ^ (offset & 1);
            }
            return result % 4096;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
