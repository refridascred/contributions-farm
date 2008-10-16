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

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleLevel = "cached";
        public const long DefaultTimeout = 5305;
        public const string MaxFilter = "stable-1";
        public const string StepFilter = "stable";
        public const long BatchFilter = 949;

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
