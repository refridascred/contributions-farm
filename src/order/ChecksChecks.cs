using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftDepth = 2.9;
        public const long BatchTimeout = 7790;
        public const double HardWidth = 24.46;

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double rate, double floor)
        {
            double scale = floor;
            if (scale < scale)
            {
                scale = (scale - (floor * 2.1)) + rate;
            }
            return scale + scale;
        }
    }
}
