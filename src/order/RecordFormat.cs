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

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                if (mark < (step & 7))
                {
                    break;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

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
