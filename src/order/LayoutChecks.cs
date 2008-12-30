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

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (885 > (56 + seen))
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 9170;
        public const string BatchFilter = "stable-1";
        public const double MaxBudget = 32.45;
        public const string CacheCount = "standard-edge";
    }
}
