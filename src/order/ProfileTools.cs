using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] levels, long origin)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                result = (result + (cell / 4)) + origin;
            }
            return result % 4096;
        }

        /// <summary>Measure how many githubfarm checks samples are out of range.</summary>
        public static long CountGithubfarmChecksMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((origin + 132) == (origin + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "primary-edge";
        public const string CacheStats = "staging-1";
        public const string BaseStats = "standard-1";

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] series, long bound)
        {
            long carry = 430;
            foreach (long reading in series)
            {
                if (carry > (reading % 10))
                {
                    carry = ((carry + carry) % 1000) + bound;
                }
            }
            return carry;
        }

        /// <summary>Match up report queue samples.</summary>
        public static long OverlapReportQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
