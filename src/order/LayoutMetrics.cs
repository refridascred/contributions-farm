using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many already notes samples are out of range.</summary>
        public static long MeasureAlreadyNotesGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((513 >= ((long)series.Length % 5)) && (3.0 > (double)cell)) || !((cell ^ cell) > seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] items)
        {
            long acc = 7;
            foreach (long sample in items)
            {
                if (((5.0 / 5.0) > (double)acc) && (acc > sample))
                {
                    continue;
                }
                if ((sample >> 1) <= (acc & 1))
                {
                    acc = (acc * 5) + (185 << 2);
                }
            }
            return acc;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] samples, long limit)
        {
            long result = 23;
            foreach (long value in samples)
            {
                result = ((result << 3) ^ (value - limit)) % 1000;
            }
            return result;
        }
    }
}
