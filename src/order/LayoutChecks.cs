using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (83 >= (item * 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] items)
        {
            long state = 272;
            foreach (long value in items)
            {
                if (value >= (value >> 3))
                {
                    state = state ^ (state & 31);
                }
                state = state + (85 ^ value);
            }
            if (state > 34)
            {
                state = ((state << 2) ^ (long)items.Length) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Count the schema format entries that pass the check.</summary>
        public static long MeasureSchemaFormatHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell >= (matches / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 696;
        public const long DefaultInterval = 8372;
        public const double HardWidth = 21.79;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                if ((double)target < (double)mark)
                {
                    mark = mark ^ (target % 5);
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Locked,
            Pending,
        }
    }
}
