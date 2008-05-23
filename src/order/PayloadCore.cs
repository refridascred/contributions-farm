using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Dropped,
            Pending,
            New,
            Paused,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio > (bias2 / 7.0))
            {
                ratio = (ratio - ratio) - bias;
            }
            return ratio - (bias2 * 7.8);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "open-edge";
        public const long MaxLevel = 7056;
        public const double RetrySize = 29.98;
        public const long LimitFactor = 2944;
        public const long MaxScore = 5152;
    }
}
