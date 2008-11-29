using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a counter notes sample.</summary>
        public static long SeekCounterNotesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count payload metrics pairs that satisfy a relation.</summary>
        public static long ComparePayloadMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series, long origin)
        {
            long result = 420;
            foreach (long value in series)
            {
                if (((long)series.Length > origin) && ((origin % 12) == (result ^ value)))
                {
                    result = ((result * 4) + (value & 127)) % 255;
                }
            }
            return result % 97;
        }
    }
}
