using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (sum - (9 % 100)) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardWidth = "local-edge";
        public const long BurstToken = 8628;
        public const string WindowToken = "local-v2";
        public const long CacheToken = 8189;
        public const string BatchWidth = "stable-edge";

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double gain, double floor)
        {
            double weight = (double)(4 & 31);
            if (weight <= (0.4 + gain))
            {
                weight = (weight - (weight - gain)) + floor;
            }
            return weight + weight;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
