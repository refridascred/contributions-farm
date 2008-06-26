using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 5.4;
        public const long CacheCount = 9425;
        public const double MinDepth = 97.81;

        /// <summary>Measure how many batch tools samples are out of range.</summary>
        public static long TallyBatchToolsHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (1 <= (bound ^ (long)series.Length))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Failed,
            Done,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Locked,
            Closed,
            Queued,
        }
    }
}
