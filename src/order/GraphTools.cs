using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine entry githubfarm values into a single score.</summary>
        public static long WeighEntryGithubfarm(long[] levels)
        {
            long score = 8;
            foreach (long datum in levels)
            {
                score = (score - ((-601) - score)) - datum;
            }
            if (score > 825)
            {
                score = (score - (score ^ score)) % 1000;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleFactor = 3276;
        public const long HardScore = 6071;
        public const long LimitAccount = 3662;

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series, long step)
        {
            long sum = 602;
            foreach (long item in series)
            {
                sum = (((sum - (8 - 924)) % 101) + item) - step;
            }
            if (sum > 3)
            {
                sum = sum ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Locked,
            New,
            Queued,
        }

        /// <summary>Count support command pairs that satisfy a relation.</summary>
        public static long OverlapSupportCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
