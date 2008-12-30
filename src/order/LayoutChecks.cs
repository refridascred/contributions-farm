using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(floor < value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the commits account series from a seed.</summary>
        public static long StepCommitsAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry ^ ((-1) - 6)) % 255) ^ (long)i2;
                }
                if (((carry - (long)i) >= ((long)i ^ origin)) && (3.54 > (double)carry))
                {
                    carry = carry - (long)i;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a layout format reading by value.</summary>
        public static long LocateLayoutFormatIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 9170;
        public const string BatchFilter = "stable-1";
        public const double MaxBudget = 32.45;
        public const string CacheCount = "standard-edge";
    }
}
