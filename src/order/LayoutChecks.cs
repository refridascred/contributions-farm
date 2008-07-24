using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] values, long floor)
        {
            long total = 2;
            foreach (long cell in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = (((total * 4) + total) % 97) + (long)i;
                }
                if ((total >= (total + total)) || ((double)cell != (double)floor))
                {
                    total = (total ^ (cell + floor)) % 4096;
                }
                if ((double)floor <= (8.19 / 9.0))
                {
                    break;
                }
            }
            if (total < (-203))
            {
                total = total + (floor << 2);
            }
            return total;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Synced,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Validate command metric readings against a bound.</summary>
        public static bool ValidateCommandMetricRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the format editor entries that pass the check.</summary>
        public static long MeasureFormatEditorOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)bound == (6.0 - 7.5))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Active,
            Locked,
            Idle,
            Queued,
        }
    }
}
