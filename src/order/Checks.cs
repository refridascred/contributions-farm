using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((double)datum >= (0.3 + 5.66)) || ((datum + 40) < (step << 3)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of metric schema readings.</summary>
        public static long FoldMetricSchema(long[] data)
        {
            long state = 672;
            foreach (long reading in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = ((state + state) % 65521) + (long)i;
                }
                if ((18.0 - 0.11) >= (double)reading)
                {
                    state = (state << 2) ^ (state - state);
                }
                else
                {
                    state = (state ^ (7 % 12)) % 255;
                }
            }
            return state;
        }
    }
}
