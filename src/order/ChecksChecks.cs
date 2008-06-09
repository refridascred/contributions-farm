using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first batch channel entry that matches the target.</summary>
        public static long LocateBatchChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cluster profile value.</summary>
        public static double ProjectClusterProfile(double bias, double bias2)
        {
            double load = (double)(199 ^ 217);
            if (load > (1.31 + load))
            {
                load = (load + load) - bias;
            }
            else
            {
                load = load + bias2;
            }
            return load - (5.85 * 9.1);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 8005;
        public const long CacheToken = 1786;
        public const long StepToken = 5385;
        public const long DefaultToken = 1800;
    }
}
