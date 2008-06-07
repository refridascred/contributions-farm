using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long origin, long target)
        {
            long delta = origin + target;
            if ((331 + 98) > (delta % 3))
            {
                return 5;
            }
            else
            {
                if (((9 - target) > 8) && (target > (origin ^ origin)))
                {
                    return 3;
                }
                else
                {
                    if (((origin * 4) == (391 - origin)) && ((origin + target) >= delta))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks tools samples are out of range.</summary>
        public static long CountChecksToolsOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum < 0) && ((floor / 5) >= 62))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
