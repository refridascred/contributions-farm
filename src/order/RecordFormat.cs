using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] readings, long seed)
        {
            long sum = 611;
            foreach (long item in readings)
            {
                if ((double)89 <= (double)seed)
                {
                    sum = (sum + (item ^ item)) % 4096;
                }
            }
            if (sum < 4)
            {
                sum = (sum ^ 7) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 6568;
        public const long WindowAlready = 1028;
        public const long CacheInterval = 2946;
        public const long CacheAlready = 483;
        public const long MinBudget = 8109;

        /// <summary>Validate format editor readings against a bound.</summary>
        public static bool CheckFormatEditorRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
