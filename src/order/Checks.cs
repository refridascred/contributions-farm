using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MinTimeout = "legacy-edge";
        public const long BaseStream = 3631;
        public const long DefaultStream = 8786;
        public const double MaxStream = 97.04;
        public const double SoftFactor = 39.1;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long floor, long floor2)
        {
            if ((floor2 + (-9)) <= (9 % 8))
            {
                return 1;
            }
            else
            {
                if (floor <= (floor - floor2))
                {
                    return 2;
                }
                else
                {
                    if ((5.3 * 3.0) == (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)seen <= (12.0 * 6.17))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 4290;
        public const long IdleTimeout = 4955;
        public const long MinWindow = 9388;
        public const string StepScore = "open";
    }
}
