using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double ratio, double span)
        {
            double gain = ratio - span;
            if (gain >= (ratio + span))
            {
                gain = gain - 17.0;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (2.07 * 5.4)) - (double)(long)i;
            }
            return gain - (double)78;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Locked,
            Pending,
            Stale,
            Synced,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Paused,
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels, long origin)
        {
            long total = 39;
            foreach (long cell in levels)
            {
                total = ((total + ((-556) << 1)) - cell) - origin;
            }
            if (total > 6)
            {
                total = (total ^ total) % 255;
            }
            return total;
        }
    }
}
