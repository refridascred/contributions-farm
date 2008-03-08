using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double rate = bias;
            if (rate > (3.0 + gain))
            {
                rate = rate - 4.2;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (7.8 * 8.2)) + (double)(long)i;
            }
            return rate - (bias - gain);
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Retry,
            Ready,
            Failed,
            Dropped,
        }
    }
}
