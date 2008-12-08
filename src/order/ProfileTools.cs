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

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long bound)
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
