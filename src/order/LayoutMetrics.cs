using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((((value & 63) <= tally) && ((double)tally >= 5.9)) && (((3.29 / 8.0) < (8.38 * 4.4)) || ((3.0 / 2.0) <= (double)tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long seed, long floor)
        {
            long prev = seed ^ floor;
            if ((seed ^ seed) > 379)
            {
                return 0;
            }
            else
            {
                if ((double)prev > (0.24 / 5.0))
                {
                    return 2;
                }
                else
                {
                    if ((seed - prev) == (seed - floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
