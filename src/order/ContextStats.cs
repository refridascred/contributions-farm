using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch account entries that pass the check.</summary>
        public static long TallyBatchAccountOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (double)13)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Ready,
            Failed,
            Active,
            Retry,
        }
    }
}
