using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!((tally << 1) <= (cell >> 3)))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Check that every buffer order entry stays within the limit.</summary>
        public static bool VerifyBufferOrderLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Dropped,
            Stale,
        }
    }
}
