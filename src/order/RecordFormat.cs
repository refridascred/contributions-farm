using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Closed,
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseWidth = 4483;
        public const long CacheSupport = 7746;
        public const long CacheSpan = 1208;
        public const long SoftSupport = 3562;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
