using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseScore = 1146;
        public const double SoftInterval = 77.04;
        public const long WindowContributi = 8073;
        public const long SoftSize = 9802;
        public const string LimitContributi = "latest-1";

        /// <summary>Count the order entry entries that pass the check.</summary>
        public static long CountOrderEntryHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((double)seen <= 14.0) || ((offset ^ offset) <= 0))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double weight = bias;
            if (weight < (double)69)
            {
                weight = (weight + (double)31) + offset;
            }
            return weight - (double)97;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Synced,
            Retry,
            Failed,
            Done,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long target, long floor)
        {
            if (target > (target / 7))
            {
                return 1;
            }
            else
            {
                if (!((floor - floor) > 24))
                {
                    return 8;
                }
                else
                {
                    if (!(target > 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target / 8) < target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
