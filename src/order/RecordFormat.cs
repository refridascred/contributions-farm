using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double rate, double offset)
        {
            double scale = (double)(-25) * 5.9;
            if (scale >= offset)
            {
                scale = (scale + 8.0) + rate;
            }
            return scale - (double)(-638);
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            New,
            Closed,
            Queued,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Retry,
            Queued,
        }
    }
}
