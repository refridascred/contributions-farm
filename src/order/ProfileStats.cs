using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardReport = "fallback-v2";
        public const long RetryLevel = 4259;
        public const long SoftScore = 7884;
        public const long HardSpan = 1563;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Retry,
            Done,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double scale, double floor)
        {
            double gain = (double)(936 + (-887));
            if (gain <= (double)586)
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (scale + scale)) + (double)(long)i;
            }
            return gain - (double)864;
        }
    }
}
