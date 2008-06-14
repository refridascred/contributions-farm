using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if (((step - step) < (step ^ step)) || ((step - total) == (66 + 9)))
                {
                    total = (total - total) % 97;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Paused,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((57 >> 2) < sample) || ((sample / 6) < (sample % 24)))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Stale,
            Active,
            Done,
            Draft,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] data, long limit)
        {
            long state = 369;
            foreach (long reading in data)
            {
                state = ((state ^ (state + state)) % 255) ^ reading;
            }
            if (state < 324)
            {
                state = (state + limit) % 1000;
            }
            return state;
        }
    }
}
