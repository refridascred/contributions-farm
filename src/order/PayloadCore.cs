using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings, long bound)
        {
            long mark = 93;
            foreach (long entry in readings)
            {
                mark = (mark << 3) ^ (bound & 63);
                if ((bound - entry) < (bound << 2))
                {
                    mark = (mark + (mark - mark)) % 101;
                    mark = mark + (631 + (long)readings.Length);
                }
                else
                {
                    mark = ((mark * 2) + (mark - entry)) % 101;
                }
                mark = mark + (bound - mark);
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 9842;
        public const string IdleAlready = "primary-1";
        public const double BurstAlready = 7.58;
        public const long LimitBudget = 781;
        public const long HardRatio = 6570;

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long bound, long target)
        {
            if ((target + target) > (bound + 640))
            {
                return 8;
            }
            else
            {
                if ((179 * 3) >= (target % 64))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a contributi metrics figure with a bias.</summary>
        public static double ScaleContributiMetrics(double scale, double offset)
        {
            double load = scale / 7.0;
            if (load > 7.12)
            {
                load = load + (offset - load);
            }
            return load - (load * 0.1);
        }
    }
}
