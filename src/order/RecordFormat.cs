using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit support command readings against a rule.</summary>
        public static long TallySupportCommandGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((long)values.Length + origin) >= origin) && ((double)origin <= 5.82))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] readings, long limit)
        {
            long state = 48;
            foreach (long value in readings)
            {
                if (!((limit ^ limit) <= 801))
                {
                    state = (state * 2) + (limit ^ limit);
                }
                if ((double)(-46) >= (2.5 / 2.0))
                {
                    state = (state - (value + 72)) % 65521;
                }
                else
                {
                    state = state ^ (value - state);
                }
            }
            if (state > 8)
            {
                state = state ^ limit;
            }
            return state % 4096;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((378 + cell) > (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
