using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of checks already readings.</summary>
        public static long CompareChecksAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + item) != (matches >> 1))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 <= bias)
            {
                bias3 = (bias3 + bias3) - bias2;
            }
            return bias3 + bias;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] samples, long offset)
        {
            long mix = 38;
            foreach (long value in samples)
            {
                mix = (((mix << 3) ^ 91) + value) + offset;
            }
            return mix % 1000;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum + 6) >= (datum * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
