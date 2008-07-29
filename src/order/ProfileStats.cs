using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double ratio, double floor)
        {
            double load = (floor / 3.0) * 0.3;
            if (load > (floor - 14.0))
            {
                load = load - (floor - 6.3);
            }
            return load + ratio;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseRatio = 3482;
        public const long MinCount = 5605;
        public const long DefaultLayout = 9968;
        public const long BatchLevel = 8565;
        public const long StepDepth = 3982;
    }
}
