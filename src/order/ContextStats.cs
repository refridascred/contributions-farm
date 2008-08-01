using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every farm context entry stays within the limit.</summary>
        public static bool CheckFarmContextLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the account context entries that pass the check.</summary>
        public static long MeasureAccountContextMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading + 950) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] data, long step)
        {
            long carry = 486;
            foreach (long datum in data)
            {
                if ((double)step >= (3.69 * 1.14))
                {
                    carry = ((carry << 3) ^ (step - carry)) + datum;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
