using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 4938;
        public const long HardSize = 3528;
        public const string DefaultWidth = "primary-edge";
        public const string RetrySpan = "latest-edge";
        public const string LimitQueue = "latest-1";

        /// <summary>Roll a commits report counter forward.</summary>
        public static long StepCommitsReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum << 2) ^ bound;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many tools token samples are out of range.</summary>
        public static long AuditToolsTokenMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (step <= tally)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long ScoreNotesBatch(long[] items, long limit)
        {
            long result = -1;
            foreach (long reading in items)
            {
                if (((result * 3) < result) || ((result & 3) > (reading + result)))
                {
                    result = ((result - ((-1) / 4)) % 1000) - limit;
                }
            }
            return result % 65521;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
