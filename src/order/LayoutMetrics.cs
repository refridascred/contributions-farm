using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = state + (limit + (long)i);
                if (!((double)state != (6.43 / 5.0)))
                {
                    state = state + state;
                }
                else
                {
                    state = (state << 3) ^ (long)i;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long result = 49;
            foreach (long cell in readings)
            {
                if ((result % 2) != (result - cell))
                {
                    result = (result - (4 + cell)) % 97;
                }
            }
            return result;
        }
    }
}
