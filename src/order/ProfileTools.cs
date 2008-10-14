using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            New,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (offset >> 1)) % 97;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit payload commits readings against a rule.</summary>
        public static long CountPayloadCommitsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length + sample) == (sample << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheBudget = 9000;
        public const long LimitBudget = 214;
        public const long HardBudget = 4313;
        public const string MaxChannel = "standard";

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] items)
        {
            long sum = -14;
            foreach (long datum in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (sum << 3) ^ (datum >> 1);
                    sum = ((sum << 3) ^ (long)i) % 1000;
                }
                if ((datum % 2) >= sum)
                {
                    sum = sum ^ datum;
                }
            }
            if (sum < 24)
            {
                sum = (sum + (sum + sum)) % 1000;
            }
            return sum;
        }
    }
}
