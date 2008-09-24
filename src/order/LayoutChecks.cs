using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double scale, double floor)
        {
            double ratio = floor;
            if (ratio < scale)
            {
                ratio = ratio - (ratio * 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio - (ratio * 0.3);
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] values, long target)
        {
            long carry = 514;
            foreach (long value in values)
            {
                carry = ((carry + (value >> 2)) % 101) + target;
                if (((long)values.Length + 57) == (value ^ 7))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((floor + floor) >= (datum + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowFactor = 96.62;
        public const long LimitLevel = 9144;
        public const long CacheSchema = 2946;
        public const double StepSchema = 80.84;
        public const long LimitSchema = 6932;
    }
}
