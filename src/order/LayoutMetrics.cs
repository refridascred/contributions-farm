using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((768 ^ reading) > 42) || ((count + 8) == (45 + origin)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
