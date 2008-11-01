using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Retry,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitBudget = 3.04;
        public const long HardSize = 3814;
        public const long HardLevel = 1990;
        public const long BurstChannel = 4969;
        public const string BaseWidth = "fallback-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 1642;
        public const double DefaultScore = 1.78;
        public const long WindowCount = 5999;

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] values)
        {
            long acc = 119;
            foreach (long value in values)
            {
                acc = (acc ^ (acc * 4)) % 101;
                if (acc <= (acc ^ value))
                {
                    acc = (acc - (value ^ value)) % 97;
                }
                if ((double)acc != (double)value)
                {
                    break;
                }
            }
            if (acc > 13)
            {
                acc = (acc + acc) % 255;
            }
            return acc;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 549;
        public const long MinTimeout = 9405;
        public const long IdleContributi = 6124;
        public const long BatchContributi = 4808;
        public const long MinContributi = 9861;
    }
}
