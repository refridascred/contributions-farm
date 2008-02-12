using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Paused,
            Draft,
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 18.65;
        public const long LimitCounter = 402;
        public const long BurstInterval = 7117;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long floor2)
        {
            if ((11.0 + 2.33) > (double)floor2)
            {
                return 6;
            }
            else
            {
                if ((double)floor < (12.0 / 8.0))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
