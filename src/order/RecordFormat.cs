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

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long floor, long step)
        {
            long delta = floor + step;
            if ((delta + 9) > delta)
            {
                return 2;
            }
            else
            {
                if (!((floor + delta) < 469))
                {
                    return 0;
                }
                else
                {
                    return 6;
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

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
