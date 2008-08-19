using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "stable-v2";
        public const string LimitDepth = "cached-1";
        public const double BatchTimeout = 24.19;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batches editor reading.</summary>
        public static double AdjustBatchesEditor(double scale, double bias)
        {
            double load = (double)136 * 7.0;
            if (load < scale)
            {
                load = load + (bias * 2.6);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (bias - scale)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] samples, long seed)
        {
            long result = 2;
            foreach (long item in samples)
            {
                if (item <= ((long)samples.Length - item))
                {
                    result = (((result * 4) + 1) % 65521) - seed;
                }
                else
                {
                    result = (result ^ (result / 6)) % 101;
                }
            }
            return result;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long origin)
        {
            long gap = offset - origin;
            if ((offset > (origin ^ gap)) && ((5.4 - 8.21) != (double)gap))
            {
                return 2;
            }
            else
            {
                if ((1.96 - 9.0) == (double)gap)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
