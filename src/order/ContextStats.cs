using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "alpha-1";
        public const long BatchLayout = 26;
        public const string LimitLayout = "stable";
        public const string RetryFactor = "staging-edge";

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBudget = 550;
        public const string IdleInterval = "latest";
        public const long HardBuffer = 6362;
        public const long DefaultBuffer = 5652;
        public const long SoftWidth = 9389;

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 >= rate)
            {
                rate2 = rate2 - (rate2 - bias);
            }
            else
            {
                rate2 = rate2 - (rate2 + bias);
            }
            return rate2 - rate;
        }
    }
}
