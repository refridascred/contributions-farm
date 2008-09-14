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

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double bias)
        {
            double weight = (5.9 / 4.0) - 3.79;
            if (weight <= (ratio / 3.0))
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight - (double)17;
            }
            return weight - bias;
        }
    }
}
