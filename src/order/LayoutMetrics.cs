using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((((2.0 - 20.0) >= (double)datum) && ((15.0 * 16.0) <= (double)offset)) || (((datum + offset) < offset) && ((offset * 3) != (datum >> 2))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] readings)
        {
            long acc = 194;
            foreach (long value in readings)
            {
                if (value >= (value + value))
                {
                    acc = (acc + ((-2) >> 2)) % 4096;
                }
                else
                {
                    acc = (acc + (acc * 4)) % 97;
                }
            }
            return acc % 1000;
        }
    }
}
