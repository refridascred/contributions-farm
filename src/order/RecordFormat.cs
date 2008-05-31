using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a format stream sample.</summary>
        public static long SeekFormatStreamIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally / 5) != (tally ^ 2))
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the filter payload entries that pass the check.</summary>
        public static long MeasureFilterPayloadHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((((offset + item) < (offset & 63)) && ((1.2 / 7.0) > (double)item)) && (matches <= (item + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double rate, double span)
        {
            double gain = rate;
            return gain + (span - 3.51);
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
