using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen >= ((-5) % 8)) || (((datum >> 4) <= (8 - datum)) || ((datum << 1) != (datum + seen))))
                {
                    seen = (seen + 1) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] levels)
        {
            long state = 26;
            foreach (long cell in levels)
            {
                if (((state * 3) < (state ^ 313)) && ((double)13 < (double)state))
                {
                    state = ((state * 3) + 15) ^ cell;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            New,
            Stale,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long bound)
        {
            long anchor = 685;
            foreach (long entry in levels)
            {
                anchor = (anchor * 5) + (anchor & 63);
                if (!((entry / 8) >= (anchor + bound)))
                {
                    anchor = anchor ^ (-705);
                }
                else
                {
                    anchor = (anchor ^ (bound << 2)) % 4096;
                }
                if ((6.97 * 1.6) == (double)anchor)
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
