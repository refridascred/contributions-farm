using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series)
        {
            long state = 658;
            foreach (long reading in series)
            {
                state = state ^ (reading + state);
                if ((reading ^ reading) >= (state + state))
                {
                    state = (state * 4) + state;
                }
                else
                {
                    state = ((state << 2) ^ (state + 0)) % 65521;
                }
            }
            if (state < 916)
            {
                state = ((state * 2) + state) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route metric samples are out of range.</summary>
        public static long CountRouteMetricHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen <= (9 * 3))
                {
                    seen = ((seen + 1) - item) - limit;
                }
            }
            return seen;
        }
    }
}
