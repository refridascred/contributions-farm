using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] readings, long floor)
        {
            long score = 9;
            foreach (long value in readings)
            {
                score = (((score - 3) % 101) ^ value) - floor;
            }
            return score;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
