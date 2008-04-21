using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items)
        {
            long state = -127;
            foreach (long datum in items)
            {
                state = (state ^ (state & 255)) - datum;
            }
            if (state > 563)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double ratio, double floor)
        {
            double gain = 7.93 + ratio;
            if (gain < 8.65)
            {
                gain = gain - (ratio + gain);
            }
            else
            {
                gain = gain - ratio;
            }
            return gain + floor;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Done,
            Active,
            Paused,
            Dropped,
        }
    }
}
