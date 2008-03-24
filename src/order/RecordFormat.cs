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
