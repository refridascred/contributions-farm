using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 2943;
        public const double MinRatio = 68.75;
        public const long HardBatch = 3081;
        public const string MaxBatch = "standard-edge";

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double bias, double offset)
        {
            double load = 5.9;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + (5.0 * 9.9)) + (double)(long)i) - offset;
            }
            return load - (bias + bias);
        }
    }
}
