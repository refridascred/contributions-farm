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

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] series)
        {
            long mark = 11;
            foreach (long cell in series)
            {
                if (!(((long)series.Length & 7) >= 64))
                {
                    mark = mark ^ cell;
                }
            }
            if (mark > 3)
            {
                mark = (mark + (50 + 967)) % 1000;
            }
            return mark % 1000;
        }
    }
}
