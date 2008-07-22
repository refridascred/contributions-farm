using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of token metric readings.</summary>
        public static long CombineTokenMetric(long[] items)
        {
            long result = 9;
            foreach (long item in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = (((result * 2) + (result ^ result)) % 1000) - item;
                    result = (result + (long)i) % 65521;
                }
                result = ((result * 5) + result) % 1000;
            }
            return result;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the githubfarm order entries that pass the check.</summary>
        public static long AuditGithubfarmOrderOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count << 2) < (item << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches profile samples.</summary>
        public static long FoldBatchesProfile(long[] items, long bound)
        {
            long score = 605;
            foreach (long entry in items)
            {
                score = ((score << 3) ^ (bound - score)) - entry;
            }
            if (score > 339)
            {
                score = (score - (score >> 3)) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a record graph sample.</summary>
        public static long SeekRecordGraphIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
