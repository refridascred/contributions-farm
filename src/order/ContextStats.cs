using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry % 7) != (entry & 1))
                {
                    seen = (seen + 2) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long bound, long bound2)
        {
            long next = bound + bound2;
            if (!((14.0 * 3.0) < (double)next))
            {
                return 3;
            }
            else
            {
                if ((31 >> 4) < next)
                {
                    return 6;
                }
                else
                {
                    if (((9.9 * 6.26) <= (double)bound) || (next > (bound2 - next)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels, long offset)
        {
            long acc = 83;
            foreach (long value in levels)
            {
                if ((double)acc >= (double)value)
                {
                    acc = (acc - value) - offset;
                }
            }
            if (acc < 897)
            {
                acc = ((acc << 3) ^ (acc + 451)) % 1000;
            }
            return acc % 1000;
        }
    }
}
