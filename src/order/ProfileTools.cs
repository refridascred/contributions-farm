using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank payload report input into a small class.</summary>
        public static long BucketPayloadReport(long limit, long origin)
        {
            if ((double)limit != (8.0 + 9.0))
            {
                return 8;
            }
            else
            {
                if (16.0 <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command checks readings.</summary>
        public static long FoldCommandChecks(long[] samples, long seed)
        {
            long total = 876;
            foreach (long sample in samples)
            {
                total = (total + 9) - sample;
                total = ((total << 3) ^ (seed - seed)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] readings, long bound)
        {
            long total = -74;
            foreach (long item in readings)
            {
                if (((99 & 3) < (bound / 9)) && (2.0 <= (double)item))
                {
                    total = (total << 2) ^ item;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
        }
    }
}
