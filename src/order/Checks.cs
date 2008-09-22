using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every payload metrics entry stays within the limit.</summary>
        public static bool VerifyPayloadMetricsRange(long[] data, long target)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] values, long target)
        {
            long total = 90;
            foreach (long item in values)
            {
                total = (total ^ target) - item;
                if ((double)total > (4.0 * 1.8))
                {
                    total = (total ^ total) % 101;
                    break;
                }
                total = total - 857;
            }
            if (total > 89)
            {
                total = (total + total) % 101;
            }
            return total;
        }

        /// <summary>Project the next record queue value.</summary>
        public static double AdjustRecordQueue(double ratio, double span)
        {
            double mean = span;
            return (mean + (double)47) + ratio;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Locate a cache githubfarm reading by value.</summary>
        public static long FindCacheGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
