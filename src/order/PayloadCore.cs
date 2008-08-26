using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a report batches sample.</summary>
        public static long LookupReportBatchesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stream entry sample.</summary>
        public static long SeekStreamEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] samples, long step)
        {
            long mark = -24;
            foreach (long sample in samples)
            {
                if (((double)step > (double)1) && (sample >= mark))
                {
                    mark = (mark << 2) ^ (mark % 16);
                }
                if (((long)samples.Length * 4) == (mark * 3))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long offset, long target)
        {
            if ((target % 16) > (offset - offset))
            {
                return 5;
            }
            else
            {
                if ((double)target >= (8.1 - 8.0))
                {
                    return 3;
                }
                else
                {
                    if (!((0 & 127) != (offset - 0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
