using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 2105;
        public const long HardSpan = 8989;
        public const long BaseScore = 9537;
        public const long IdleFilter = 8162;
        public const long BatchSize = 3303;

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double scale, double offset)
        {
            double mean = offset - (scale - scale);
            if (mean > mean)
            {
                mean = mean + mean;
            }
            return mean - (5.61 + offset);
        }
    }
}
