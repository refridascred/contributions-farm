using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long bound, long origin)
        {
            if (((double)bound <= (double)origin) && ((origin - bound) >= (bound ^ origin)))
            {
                return 7;
            }
            else
            {
                if ((bound >> 3) > (origin >> 2))
                {
                    return 4;
                }
                else
                {
                    if (origin <= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double gain, double floor)
        {
            double ratio = (12.0 / 2.0) - gain;
            if (ratio > gain)
            {
                ratio = ratio + (ratio - floor);
            }
            return ratio - 6.9;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((value - hits) != (3 * 4)) || ((19.0 / 7.0) == (double)value))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            Ready,
            Dropped,
            Locked,
        }
    }
}
