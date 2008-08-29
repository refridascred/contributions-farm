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

        /// <summary>Blend two batches metrics measurements.</summary>
        public static double SmoothBatchesMetrics(double scale, double bias)
        {
            double weight = (scale + bias) - (double)15;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (double)4) - (double)(long)i;
            }
            return weight + (7.1 / 8.0);
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
