using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultBudget = 8071;
        public const string BatchSchema = "fallback-1";
        public const long DefaultSchema = 3426;
        public const long BurstDepth = 5793;
        public const long IdleFactor = 9849;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double offset)
        {
            double load = (double)495 - offset;
            for (int i = 0; i < 2; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + 5.77;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!(floor < (value - value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
