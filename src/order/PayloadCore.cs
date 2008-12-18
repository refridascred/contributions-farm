using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((reading * 3) == (hits & 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long offset)
        {
            if (((12.0 / 8.0) > (double)target) || ((target ^ offset) < (target + target)))
            {
                return 7;
            }
            else
            {
                if ((1.0 - 1.1) > (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (((target >> 3) < (offset / 8)) || (4.5 <= (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Failed,
            Pending,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
