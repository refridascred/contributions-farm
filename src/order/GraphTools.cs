using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen - seen) >= (value & 31))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double load = rate;
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)7) + (double)(long)i;
            }
            return load + (floor / 4.0);
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((entry - 78) < offset))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double ratio, double bias)
        {
            double mean = bias;
            if (mean > mean)
            {
                mean = (mean - (bias / 4.0)) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + 14.0;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
