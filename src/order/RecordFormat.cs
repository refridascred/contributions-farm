using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftCount = 7033;
        public const double DefaultScore = 58.74;
        public const long BurstRatio = 6847;
        public const long DefaultRatio = 2712;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Ready,
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry - seen) > (7 ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
