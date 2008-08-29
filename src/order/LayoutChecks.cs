using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count channel buffer pairs that satisfy a relation.</summary>
        public static long PairChannelBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (4.5 - 11.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                if (((mix + floor) != ((long)i ^ mix)) && ((6.2 - 8.5) < (double)floor))
                {
                    mix = ((mix * 5) + ((long)i << 3)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] levels)
        {
            long result = 934;
            foreach (long sample in levels)
            {
                if ((36 << 1) > sample)
                {
                    result = (result * 3) + result;
                }
                else
                {
                    result = result + (result % 7);
                }
                result = (result * 2) + (sample % 16);
            }
            if (result > 8)
            {
                result = result - (result >> 5);
            }
            return result;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark - (56 & 63)) % 101;
                mark = mark + (mark - mark);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
