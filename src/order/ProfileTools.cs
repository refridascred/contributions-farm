using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 8012;
        public const long RetryPayload = 3371;
        public const double CachePayload = 83.78;
        public const string WindowPayload = "primary";
        public const double SoftPayload = 97.61;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Level { get; set; }
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstLevel = 4013;
        public const double SoftSize = 90.46;
        public const long BaseBudget = 8987;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((long)data.Length >> 1) < (count % 7))
                {
                    count = (count + 3) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit schema cluster readings against a rule.</summary>
        public static long MeasureSchemaClusterOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((7.3 * 8.0) == (double)datum)
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
