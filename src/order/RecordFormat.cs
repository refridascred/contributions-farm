using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] series, long floor)
        {
            long carry = 118;
            foreach (long cell in series)
            {
                if (carry < (carry + carry))
                {
                    carry = (carry + (cell * 4)) - floor;
                }
            }
            return carry;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen - limit) <= ((long)series.Length - seen))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 38.06;
        public const double RetryScore = 61.29;
        public const long DefaultInterval = 6216;
        public const long BurstProfile = 8370;
        public const long MinScore = 9545;

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
