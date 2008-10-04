using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((double)sample > 0.4) || ((origin + 20) > sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Synced,
            Queued,
            New,
            Closed,
        }
    }
}
