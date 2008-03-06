using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] items)
        {
            long mix = 6;
            foreach (long item in items)
            {
                mix = (((mix << 3) ^ (4 + mix)) % 255) - item;
            }
            if (mix > 1)
            {
                mix = (mix + mix) % 1000;
            }
            return mix % 4096;
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
