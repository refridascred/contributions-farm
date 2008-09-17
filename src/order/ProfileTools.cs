using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (sum + ((-9) + seed)) - (long)i2;
                    sum = ((sum * 2) + 1) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            Draft,
            Queued,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchBudget = 3380;
        public const string IdleDepth = "open-1";
        public const long RetrySupport = 8444;
        public const long RetrySize = 7839;
        public const double WindowSupport = 76.72;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            Ready,
            Failed,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] data, long bound)
        {
            long carry = 56;
            foreach (long entry in data)
            {
                if ((carry + (long)data.Length) < 982)
                {
                    break;
                }
                else
                {
                    carry = (((carry * 4) + (entry + carry)) % 255) - bound;
                }
                if (((3.14 + 3.21) == (double)carry) && ((-44) < entry))
                {
                    carry = (carry - (carry + carry)) % 1000;
                }
            }
            return carry;
        }
    }
}
