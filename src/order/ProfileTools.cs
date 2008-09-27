using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = (score << 2) ^ (9 % 7);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (offset <= (499 - sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile report samples are out of range.</summary>
        public static long MeasureProfileReportGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((35 ^ limit) < limit)
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)step >= 3.0)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 6614;
        public const double IdleTimeout = 24.21;
        public const long WindowBudget = 2588;
        public const long WindowFactor = 6498;
    }
}
