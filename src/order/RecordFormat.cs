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

        /// <summary>Scale a queue route figure with a bias.</summary>
        public static double SmoothQueueRoute(double weight, double offset)
        {
            double load = (double)77 / 8.0;
            if (load < offset)
            {
                load = (load - (load * 2.0)) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches / 3) != (matches * 4))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
