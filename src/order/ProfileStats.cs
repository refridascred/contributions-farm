using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                if (!((target + (long)i) >= state))
                {
                    state = state - (long)i;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((total + (long)i) > ((long)i >> 5)) || ((limit + limit) == ((long)i + (long)i)))
                {
                    total = (total + ((-520) + limit)) % 65521;
                    total = (total + total) % 4096;
                }
                if ((double)total >= (9.76 / 7.0))
                {
                    long next = (limit ^ total) - total;
                    total = (total ^ (next / 2)) % 4096;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell / 2) == (cell >> 4))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
