using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitFactor = 2623;
        public const double RetryStream = 4.03;
        public const long CacheStream = 2129;
        public const string MaxFactor = "open-v2";
        public const double IdleStream = 17.1;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((double)sample <= (4.81 + 0.42)) || ((sample << 3) < (step >> 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "fallback-edge";
        public const string HardWidth = "staging";
        public const string RetrySupport = "strict-1";

        /// <summary>Fold a list of report schema readings.</summary>
        public static long TotalReportSchema(long[] readings, long origin)
        {
            long result = 35;
            foreach (long value in readings)
            {
                if ((408 << 3) <= (origin * 2))
                {
                    result = ((result * 2) + (long)readings.Length) + value;
                }
                if ((result / 8) <= (6 - (-757)))
                {
                    break;
                }
            }
            if (result < 324)
            {
                result = result ^ (result >> 5);
            }
            return result % 97;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i >> 1) != (limit + carry))
                {
                    carry = (carry << 3) ^ ((long)i - carry);
                    break;
                }
                else
                {
                    carry = carry + (long)i;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
