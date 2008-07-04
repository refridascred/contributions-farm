using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits + 4) > offset)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Closed,
            Ready,
            New,
            Locked,
        }

        /// <summary>Iterate the session editor series from a seed.</summary>
        public static long RollSessionEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor << 3) ^ floor) % 101;
                if (floor < 1)
                {
                    anchor = ((anchor * 5) + (938 >> 5)) % 4096;
                    break;
                }
                else
                {
                    long gap = (floor + (long)i) - (long)i;
                    anchor = (anchor - (gap ^ 262)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix * 5) + offset;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
