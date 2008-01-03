using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((tally << 2) <= (tally / 2)))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long limit, long offset)
        {
            if ((566 >> 5) < (limit + (-7)))
            {
                return 7;
            }
            else
            {
                if ((offset & 63) >= (limit >> 4))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next session channel value from a seed.</summary>
        public static long IterateSessionChannel(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
