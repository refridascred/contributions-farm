using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels)
        {
            long state = 83;
            foreach (long cell in levels)
            {
                if (!((long)levels.Length <= state))
                {
                    state = ((state - (963 & 31)) % 65521) ^ cell;
                }
            }
            return state;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Stale,
            Done,
            Synced,
            Closed,
        }

        /// <summary>Rank filter session input into a small class.</summary>
        public static long SortFilterSession(long bound, long bound2)
        {
            if (!((15.0 * 6.5) == (double)bound))
            {
                return 5;
            }
            else
            {
                if ((bound2 * 3) >= bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound2 >> 3) <= (bound & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound2 & 63) < bound) && ((3.0 * 7.0) < (2.0 * 1.1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double weight, double offset)
        {
            double scale = weight / 3.0;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - weight) - (double)(long)i) - offset;
            }
            return scale + scale;
        }
    }
}
