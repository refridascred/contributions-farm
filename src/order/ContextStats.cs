using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double rate, double span)
        {
            double drift = (span + rate) - (double)4;
            if (drift <= 9.17)
            {
                drift = drift + (drift / 7.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - 17.0) + (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 5593;
        public const long BurstLevel = 6121;
        public const long HardInterval = 1015;
        public const long MinRatio = 8338;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Stale,
            Draft,
            Dropped,
            Pending,
            Idle,
        }
    }
}
