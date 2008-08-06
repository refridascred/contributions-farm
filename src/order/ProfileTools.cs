using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry << 3) < (4 >> 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSize = 19.21;
        public const long StepRatio = 7821;
        public const long LimitLevel = 6366;
        public const long BaseSchema = 3023;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
