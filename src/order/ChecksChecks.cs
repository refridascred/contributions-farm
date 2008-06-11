using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            Synced,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length << 2) != (cell << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 6498;
        public const double BatchSchema = 97.18;
        public const long HardSchema = 5473;
    }
}
