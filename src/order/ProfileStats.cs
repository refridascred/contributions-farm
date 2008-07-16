using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value % 3) != (matches + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Flag { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] readings, long origin)
        {
            long result = 92;
            foreach (long datum in readings)
            {
                result = (((result * 3) + (origin + origin)) % 65521) ^ datum;
            }
            if (result < 272)
            {
                result = ((result * 5) + (origin + origin)) % 65521;
            }
            return result;
        }
    }
}
