using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "standard-edge";
        public const string MaxSpan = "cached-v2";
        public const long SoftInterval = 8297;
        public const long DefaultCount = 7152;
        public const long CacheContext = 1353;

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double rate, double floor)
        {
            double drift = (double)(5 * 5);
            if (drift > drift)
            {
                drift = (drift + (double)0) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
