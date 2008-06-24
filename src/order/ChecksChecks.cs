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

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] values)
        {
            long total = 18;
            foreach (long reading in values)
            {
                long edge = 193;
                if ((0.56 - 8.87) < (double)edge)
                {
                    total = (total - (1 - reading)) % 65521;
                    continue;
                }
                else
                {
                    total = ((total << 2) ^ total) % 4096;
                }
                if ((reading ^ total) == (total + total))
                {
                    total = (total - (total + total)) % 255;
                }
            }
            return total;
        }
    }
}
