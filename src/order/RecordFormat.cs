using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of counter graph readings.</summary>
        public static long MatchCounterGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitDepth = 8878;
        public const double RetryFactor = 31.04;
        public const double WindowWidth = 21.29;
        public const double SoftSchema = 70.2;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long origin, long limit)
        {
            long offset = origin + limit;
            if (!((origin / 8) >= limit))
            {
                return 6;
            }
            else
            {
                if ((limit + limit) != (offset << 1))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
