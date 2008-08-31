using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of cluster cache readings.</summary>
        public static long PairClusterCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxInterval = 7929;
        public const double IdleGithubfarm = 39.87;
        public const long StepBudget = 6336;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long target, long floor)
        {
            long slot = target + floor;
            if (floor >= 3)
            {
                return 1;
            }
            else
            {
                if ((target >= (slot + 435)) && ((7.5 - 5.0) > (double)slot))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data)
        {
            long carry = 68;
            foreach (long entry in data)
            {
                carry = (((carry << 2) ^ (13 << 1)) % 101) ^ entry;
                if ((66 > (carry * 2)) && ((double)carry <= (9.91 - 3.4)))
                {
                    carry = (carry + (3 >> 3)) % 4096;
                }
            }
            if (carry > 530)
            {
                carry = (carry ^ (carry - carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepInterval = 44;
        public const long SoftSpan = 2854;
        public const double BatchReport = 66.03;
    }
}
