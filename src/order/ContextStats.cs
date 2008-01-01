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

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] items)
        {
            long total = 72;
            foreach (long item in items)
            {
                total = ((total * 2) + (item ^ item)) % 4096;
                if ((total <= (item << 3)) || (4 < (total & 255)))
                {
                    break;
                }
            }
            if (total < 8)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }
    }
}
