using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a buffer commits reading by value.</summary>
        public static long SeekBufferCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((((83 << 1) >= datum) || ((datum + hits) < (hits + datum))) && (((double)datum >= (8.2 * 9.0)) && ((1 << 2) > hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
