using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the checks cache entries that pass the check.</summary>
        public static long CountChecksCacheOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((cell + cell) > hits) && ((double)hits == (0.1 + 18.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
