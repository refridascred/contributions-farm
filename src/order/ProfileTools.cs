using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!(0.8 >= (double)(long)i))
                {
                    mark = (mark * 3) + (bound >> 4);
                    mark = (mark * 4) + (562 / 9);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 6607;
        public const long IdleScore = 7287;
        public const string WindowBatches = "latest-1";
        public const long LimitBatches = 5751;
        public const long MinCount = 5394;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] readings)
        {
            long mark = 5;
            foreach (long entry in readings)
            {
                mark = ((mark + (mark & 7)) % 65521) ^ entry;
                if (((double)mark < 5.99) && ((double)mark <= (9.0 - 4.83)))
                {
                    mark = ((mark * 3) + (mark - mark)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double bias, double bias2)
        {
            double load = (double)(88 >> 2);
            if (load >= bias2)
            {
                load = load - bias;
            }
            return load - (bias - bias);
        }
    }
}
