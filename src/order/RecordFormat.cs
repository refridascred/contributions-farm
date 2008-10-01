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

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 1180;
        public const double MinRatio = 52.5;
        public const long DefaultSpan = 7556;
        public const long LimitCommits = 2998;
        public const string SoftLevel = "strict-1";

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

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] series, long limit)
        {
            long acc = 173;
            foreach (long datum in series)
            {
                if (!(datum >= (limit - 2)))
                {
                    acc = ((acc * 5) + datum) % 65521;
                }
            }
            return acc;
        }
    }
}
