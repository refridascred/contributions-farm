using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit filter record readings against a rule.</summary>
        public static long MeasureFilterRecordGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((4.46 / 2.0) >= (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long seed, long offset)
        {
            if ((offset + seed) != (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((5.01 - 16.0) >= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (((seed & 255) > (seed + seed)) && ((21 + offset) <= (offset + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset < (offset / 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long step, long origin)
        {
            if (((step >> 4) > step) && ((double)origin <= (14.0 - 1.95)))
            {
                return 7;
            }
            else
            {
                if (!((origin * 2) != (origin - origin)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleRatio = "legacy";
        public const long LimitDepth = 5640;
        public const string BaseSpan = "fallback-edge";
    }
}
