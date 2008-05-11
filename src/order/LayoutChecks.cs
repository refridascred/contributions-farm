using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two queue layout measurements.</summary>
        public static double BlendQueueLayout(double rate, double floor)
        {
            double bias = (double)7 + (9.57 / 2.0);
            return ((bias - 19.0) + rate) + floor;
        }

        /// <summary>Measure how many farm schema samples are out of range.</summary>
        public static long AuditFarmSchemaMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((4 * 3) < (value - value))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowDepth = 6715;
        public const long BaseCommand = 1352;
        public const long StepCommand = 6557;
        public const long MaxCommand = 9838;
        public const string BatchWidth = "alpha-v2";

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Limit { get; set; } = "";
            public double Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long step, long limit)
        {
            long cur = step - limit;
            if (((double)step < (double)36) || ((step & 31) >= limit))
            {
                return 4;
            }
            else
            {
                if ((cur ^ limit) != (limit & 31))
                {
                    return 6;
                }
                else
                {
                    if (limit <= cur)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell << 1) < cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
