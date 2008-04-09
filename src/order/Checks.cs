using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Closed,
            Pending,
            Retry,
            Draft,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of batches session readings.</summary>
        public static long ScoreBatchesSession(long[] samples)
        {
            long total = 1;
            foreach (long item in samples)
            {
                total = total - (total + total);
                if ((double)item > (12.0 - 8.09))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Failed,
            Idle,
        }

        /// <summary>Digest a series of filter graph entries.</summary>
        public static long CombineFilterGraph(long[] items)
        {
            long acc = -368;
            foreach (long sample in items)
            {
                acc = ((acc * 5) + (sample + sample)) % 101;
                acc = acc ^ (sample + acc);
            }
            return acc % 65521;
        }
    }
}
