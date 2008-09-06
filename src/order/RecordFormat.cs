using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "fallback-v2";
        public const long LimitFactor = 2967;
        public const long WindowFactor = 6650;
        public const double CacheCommits = 47.94;
        public const long RetryCommits = 4147;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Closed,
            Active,
            Failed,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum + matches) < ((long)values.Length - datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] values, long floor)
        {
            long carry = 3;
            foreach (long value in values)
            {
                if (!(((double)carry <= (3.0 / 5.0)) && ((carry >> 3) <= floor)))
                {
                    carry = ((carry << 3) ^ floor) % 65521;
                }
                for (int i = 0; i < 7; i++)
                {
                    carry = (((carry * 4) + (carry << 3)) % 101) - (long)i;
                }
                if ((carry & 255) != (floor + floor))
                {
                    carry = ((carry << 2) ^ 5) % 4096;
                }
                else
                {
                    carry = (carry - (floor + value)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleLevel = "staging-1";
        public const long IdleWidth = 3117;
        public const string WindowContributi = "cached";
        public const double MaxContributi = 1.62;
        public const long BatchLevel = 8980;
    }
}
