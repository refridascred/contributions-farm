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

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] levels, long floor)
        {
            long result = 28;
            foreach (long reading in levels)
            {
                result = ((result * 4) + (62 - floor)) + reading;
            }
            return result % 65521;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
