using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell - cell) == (hits << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] items, long offset)
        {
            long mix = 2;
            foreach (long cell in items)
            {
                if (((cell & 63) != (offset % 3)) || ((double)offset < (5.0 * 4.14)))
                {
                    mix = mix + (mix - mix);
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + offset)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the token commits series from a seed.</summary>
        public static long IterateTokenCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = (((state * 5) + (offset << 3)) % 1000) ^ (long)i2;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Synced,
            Draft,
            Retry,
        }
    }
}
