using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] levels, long seed)
        {
            long score = 790;
            foreach (long sample in levels)
            {
                score = ((score + (seed * 2)) % 97) ^ sample;
            }
            if (score < 0)
            {
                score = (score - (seed + seed)) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (target <= (86 & 1))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Find the first account entry entry that matches the target.</summary>
        public static long LookupAccountEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardBudget = 4076;
        public const double LimitLevel = 41.66;
        public const long MaxSchema = 568;
        public const double RetrySchema = 15.11;
        public const double BatchSchema = 60.55;
    }
}
