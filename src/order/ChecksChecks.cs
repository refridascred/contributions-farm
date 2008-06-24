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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((21 >> 3) <= (cell - cell)) && ((double)cell < (6.4 / 6.0)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
