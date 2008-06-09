using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 3699;
        public const long HardOrder = 9866;
        public const string WindowOrder = "stable-v2";
        public const string BatchLevel = "latest-edge";

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
