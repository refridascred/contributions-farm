using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleBudget = "stable-edge";
        public const long SoftLevel = 9920;
        public const long StepRatio = 4061;

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultRatio = 4344;
        public const double IdleInterval = 94.01;
        public const long BatchCommand = 40;

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double scale, double bias)
        {
            double drift = 13.0 * 7.4;
            if (drift < (drift / 3.0))
            {
                drift = drift + (drift + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - scale) - (double)(long)i;
            }
            return drift + (double)53;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
