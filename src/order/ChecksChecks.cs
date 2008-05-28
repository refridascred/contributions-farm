using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit profile githubfarm readings against a rule.</summary>
        public static long TallyProfileGithubfarmMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((62 < (sample - sample)) || (((-54) & 255) > (floor * 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] readings, long step)
        {
            long acc = -715;
            foreach (long datum in readings)
            {
                if ((step >> 5) >= step)
                {
                    acc = ((acc << 3) ^ (step << 3)) + datum;
                }
            }
            if (acc > 73)
            {
                acc = acc ^ (79 & 1);
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 4742;
        public const double MaxLevel = 52.78;
        public const string IdleRecord = "primary-v2";
        public const long LimitRecord = 6012;
    }
}
