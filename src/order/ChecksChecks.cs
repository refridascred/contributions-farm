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

        /// <summary>Rank queue already input into a small class.</summary>
        public static long GradeQueueAlready(long seed, long floor)
        {
            if ((floor >> 2) < (floor + seed))
            {
                return 1;
            }
            else
            {
                if ((double)seed >= 1.5)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

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
