using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double rate, double span)
        {
            double drift = (span * 3.7) + (span * 6.7);
            return (drift - 2.2) + rate;
        }

        /// <summary>Look up the position of a editor account sample.</summary>
        public static long LookupEditorAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] samples, long seed)
        {
            long mark = 906;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark * 2) + ((long)i + seed)) % 101;
                    mark = (mark - (81 >> 2)) % 4096;
                }
                if (!(5.7 <= (double)mark))
                {
                    mark = (mark - mark) % 97;
                }
                else
                {
                    mark = ((mark * 3) + cell) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Iterate the token metric series from a seed.</summary>
        public static long RollTokenMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                if ((15.0 / 4.0) != (double)(long)i)
                {
                    mark = (mark * 4) + ((long)i + mark);
                    continue;
                }
                if ((double)mark >= (19.0 - 1.6))
                {
                    mark = (mark * 2) + (target ^ 787);
                    mark = ((mark << 2) ^ (target + mark)) % 4096;
                }
                else
                {
                    mark = (mark - target) % 255;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
