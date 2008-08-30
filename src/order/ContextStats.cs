using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] readings, long origin)
        {
            long sum = 17;
            foreach (long entry in readings)
            {
                if (((double)sum < (double)origin) && (sum > origin))
                {
                    sum = ((sum - origin) % 1000) + entry;
                }
                else
                {
                    sum = ((sum * 2) + (913 * 3)) % 4096;
                }
                sum = (sum + (long)readings.Length) % 4096;
                sum = (sum - 1) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry < count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate report support readings against a bound.</summary>
        public static bool CheckReportSupportBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
