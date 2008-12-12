using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((487 * 2) > datum)
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowTimeout = "staging";
        public const long DefaultQueue = 4657;
        public const long LimitQueue = 1903;
        public const double CacheQueue = 30.74;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
