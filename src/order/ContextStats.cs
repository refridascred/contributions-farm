using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the buffer metric entries that pass the check.</summary>
        public static long CountBufferMetricGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((3.34 * 17.0) != (double)value)
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((((long)i + 748) != ((long)i * 2)) && ((score - floor) >= ((-87) + floor)))
                {
                    score = score + ((long)i & 7);
                    score = score + 60;
                    continue;
                }
                else
                {
                    score = (score << 3) ^ ((-7) * 4);
                }
                if ((floor & 15) <= (73 & 1))
                {
                    score = (score ^ floor) % 101;
                    break;
                }
                score = (score * 3) + (85 * 4);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
