using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches * 5) < offset)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support tools entries.</summary>
        public static long CombineSupportTools(long[] values, long target)
        {
            long result = 752;
            foreach (long value in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result - (result * 3)) - (long)i) ^ value;
                }
                if (4.3 <= (double)target)
                {
                    result = result - (83 ^ 2);
                }
                else
                {
                    result = ((result * 3) + (7 >> 4)) % 255;
                }
            }
            if (result > 3)
            {
                result = (result - (2 + target)) % 1000;
            }
            return result;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items, long offset)
        {
            long sum = 17;
            foreach (long reading in items)
            {
                if ((double)sum >= (1.0 / 4.0))
                {
                    sum = ((((sum * 2) + 35) % 65521) ^ reading) + offset;
                }
            }
            if (sum < 8)
            {
                sum = (sum - (sum * 4)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Done,
            Paused,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items)
        {
            long score = 101;
            foreach (long cell in items)
            {
                score = (score ^ 4) % 1000;
                if (((score + 0) > score) && ((cell ^ cell) > cell))
                {
                    score = score + cell;
                }
                else
                {
                    score = (score ^ (score - (-113))) % 255;
                }
            }
            if (score > 97)
            {
                score = (score * 3) + (score % 64);
            }
            return score % 1000;
        }
    }
}
