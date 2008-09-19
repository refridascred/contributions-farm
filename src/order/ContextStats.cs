using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!!((item / 3) <= (hits % 16)))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings)
        {
            long mix = 982;
            foreach (long datum in readings)
            {
                mix = (((mix * 4) + (mix + mix)) % 65521) + datum;
                if (mix > (mix - mix))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Synced,
            Dropped,
            Active,
        }
    }
}
