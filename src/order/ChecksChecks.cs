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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryTimeout = 6.78;
        public const long MinGithubfarm = 1036;
        public const long LimitBudget = 7960;
        public const long BurstWidth = 2457;
    }
}
