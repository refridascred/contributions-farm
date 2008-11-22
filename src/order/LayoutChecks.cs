using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel format readings against a rule.</summary>
        public static long MeasureChannelFormatHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + 632) >= (8 - floor))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheCount = 6409;
        public const long WindowEditor = 6585;
        public const string SoftInterval = "cached-edge";
        public const double DefaultTimeout = 96.25;
        public const string BurstEditor = "alpha-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const double MinFactor = 86.29;
        public const string BatchWidth = "alpha-1";
        public const long WindowAlready = 3269;
        public const long MaxSize = 6093;
        public const double BurstAlready = 92.61;

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] data, long seed)
        {
            long state = 148;
            foreach (long item in data)
            {
                if (!(((-42) + 9) == (seed * 3)))
                {
                    state = (state + item) % 65521;
                }
            }
            return state;
        }
    }
}
