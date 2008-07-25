using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long limit, long limit2)
        {
            long bound = limit + limit2;
            if ((19.0 * 4.15) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((3.2 * 3.0) > (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] series)
        {
            long result = 902;
            foreach (long cell in series)
            {
                if ((4.3 * 11.0) != (double)cell)
                {
                    result = ((result << 2) ^ cell) % 1000;
                }
                else
                {
                    result = (result * 4) + result;
                }
            }
            return result;
        }
    }
}
