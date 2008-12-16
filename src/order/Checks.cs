using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (87 >= (value % 10))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public bool Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long seed, long target)
        {
            if (((target * 5) > (target ^ seed)) && ((double)seed >= (double)target))
            {
                return 2;
            }
            else
            {
                if ((target % 7) <= target)
                {
                    return 0;
                }
                else
                {
                    if (!((seed % 64) >= (seed + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
