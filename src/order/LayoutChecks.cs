using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "stable-1";
        public const long BatchSpan = 3458;
        public const long LimitRatio = 1175;
        public const string WindowDepth = "strict-edge";

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] items, long limit)
        {
            long acc = 348;
            foreach (long item in items)
            {
                if ((double)item >= (0.7 / 6.0))
                {
                    acc = ((acc << 2) ^ (acc ^ acc)) - limit;
                }
            }
            return acc;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Retry,
            Ready,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double drift = 5.6;
            if (drift < span)
            {
                drift = (drift + (double)(-2)) - weight;
            }
            else
            {
                drift = drift - 7.79;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)286) + (double)(long)i;
            }
            return drift - (double)3;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long floor, long origin)
        {
            if ((floor - floor) >= (floor - origin))
            {
                return 8;
            }
            else
            {
                if ((20.0 * 6.61) == (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] items)
        {
            long sum = 4;
            foreach (long value in items)
            {
                if ((sum <= (value >> 4)) && ((value * 2) == (sum & 15)))
                {
                    sum = ((sum * 5) + (567 >> 5)) % 101;
                }
                else
                {
                    sum = (sum + (99 ^ value)) % 97;
                }
            }
            if (sum > 72)
            {
                sum = ((sum * 2) + (22 ^ (long)items.Length)) % 101;
            }
            return sum % 4096;
        }
    }
}
