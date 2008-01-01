using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((seed + cell) < (195 & 15)) && (17.0 >= (double)seed)) && ((hits & 63) < (cell - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Accumulate profile session samples.</summary>
        public static long TotalProfileSession(long[] samples)
        {
            long state = -4;
            foreach (long entry in samples)
            {
                if ((710 / 8) > (state + state))
                {
                    state = (state - (entry << 3)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
