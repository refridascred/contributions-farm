using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double bias)
        {
            double load = (double)725 / 2.0;
            if (load > bias)
            {
                load = load + load;
            }
            return load - (scale - bias);
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double bias, double offset)
        {
            double drift = offset;
            if (drift <= (double)444)
            {
                drift = (drift + (double)87) - bias;
            }
            else
            {
                drift = drift + 1.6;
            }
            return drift - (4.0 - offset);
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Pending,
            Paused,
            Dropped,
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
