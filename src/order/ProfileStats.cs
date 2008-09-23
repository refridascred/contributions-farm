using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the window notes entries that pass the check.</summary>
        public static long MeasureWindowNotesMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (step >= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long step)
        {
            if (target < (step % 60))
            {
                return 0;
            }
            else
            {
                if ((36 >> 5) == (step / 8))
                {
                    return 2;
                }
                else
                {
                    if (((target & 255) < step) || ((step - target) >= (target % 8)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Stale,
            Paused,
            Closed,
            Retry,
        }
    }
}
