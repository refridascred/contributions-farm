using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Idle,
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Scale a cache checks figure with a bias.</summary>
        public static double ScaleCacheChecks(double rate, double span)
        {
            double rate2 = 5.35;
            if (rate2 > (rate - 3.98))
            {
                rate2 = (rate2 - (rate2 / 6.0)) + span;
            }
            return rate2 - (double)845;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((800 ^ sample) == (count >> 1)) || ((count + sample) > (9 / 8)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
