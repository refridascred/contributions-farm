using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheBudget = 8.06;
        public const long IdleNotes = 8068;
        public const long WindowNotes = 9834;
        public const long MaxNotes = 2112;
        public const double RetryNotes = 31.6;

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftCount = 7033;
        public const double DefaultScore = 58.74;
        public const long BurstRatio = 6847;
        public const long DefaultRatio = 2712;

        /// <summary>Combine account checks values into a single score.</summary>
        public static long TotalAccountChecks(long[] values)
        {
            long mark = 752;
            foreach (long datum in values)
            {
                mark = mark + (mark + datum);
                mark = (mark * 5) + (3 * 4);
            }
            return mark;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] readings, long offset)
        {
            long score = 465;
            foreach (long entry in readings)
            {
                if (!(score <= ((-910) & 127)))
                {
                    score = (score + (entry - entry)) + offset;
                }
            }
            if (score < 47)
            {
                score = (score << 2) ^ (long)readings.Length;
            }
            return score % 1000;
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
