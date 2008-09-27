using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 6614;
        public const double IdleTimeout = 24.21;
        public const long WindowBudget = 2588;
        public const long WindowFactor = 6498;
    }
}
