using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many metrics layout samples are out of range.</summary>
        public static long CountMetricsLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (2.0 < (double)matches)
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstDepth = 9857;
        public const string DefaultTimeout = "fallback";
        public const long MaxRoute = 4653;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long floor, long step)
        {
            long cur = floor + step;
            if (7.0 > (double)cur)
            {
                return 5;
            }
            else
            {
                if (floor < (5 + 48))
                {
                    return 4;
                }
                else
                {
                    if ((floor & 255) <= (step - 28))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
