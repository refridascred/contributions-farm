using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long origin, long limit)
        {
            if (origin > (limit + origin))
            {
                return 5;
            }
            else
            {
                if (((limit - 3) <= (origin - origin)) || (((-7) - origin) >= limit))
                {
                    return 3;
                }
                else
                {
                    if (((origin >> 1) < limit) && (458 < (limit * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] items)
        {
            long result = 1;
            foreach (long reading in items)
            {
                if (2.8 <= (double)reading)
                {
                    result = ((result * 3) + (reading & 255)) % 255;
                }
            }
            if (result < 7)
            {
                result = result ^ (29 * 5);
            }
            return result;
        }
    }
}
