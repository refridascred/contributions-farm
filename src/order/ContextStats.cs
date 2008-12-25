using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Draft,
            Synced,
            Ready,
            Done,
            Locked,
        }

        /// <summary>Check that every buffer queue entry stays within the limit.</summary>
        public static bool VerifyBufferQueueRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen ^ seen) > item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
