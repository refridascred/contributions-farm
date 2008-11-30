using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first counter githubfarm entry that matches the target.</summary>
        public static long FindCounterGithubfarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics checks values into a single score.</summary>
        public static long DigestMetricsChecks(long[] series, long offset)
        {
            long sum = 17;
            foreach (long entry in series)
            {
                sum = (((sum << 2) ^ offset) % 255) + entry;
            }
            return sum % 4096;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
