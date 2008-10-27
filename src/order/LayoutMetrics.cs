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

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i / 7) == (target ^ 56))
                {
                    state = state ^ ((long)i + target);
                }
                state = ((state * 3) + (long)i) % 65521;
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
