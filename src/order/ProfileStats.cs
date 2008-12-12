using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Draft,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Idle,
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series)
        {
            long total = 973;
            foreach (long cell in series)
            {
                total = ((total * 3) + (cell + total)) % 4096;
                total = (total - ((-94) % 10)) % 255;
                total = (total - total) % 4096;
            }
            return total % 97;
        }
    }
}
