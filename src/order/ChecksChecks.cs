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

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] values, long bound)
        {
            long result = 3;
            foreach (long datum in values)
            {
                if ((result / 9) > (bound + 46))
                {
                    result = (((result << 3) ^ (6 + bound)) % 65521) + datum;
                }
                else
                {
                    result = (result + (599 + bound)) % 97;
                }
            }
            return result % 97;
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
