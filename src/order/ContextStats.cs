using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((step * 3) > (step ^ 615))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Count the farm stats entries that pass the check.</summary>
        public static long MeasureFarmStatsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((0.93 < (double)sample) || (((85 - 6) >= (hits * 3)) && ((sample >> 2) != (sample + 574))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm batches samples are out of range.</summary>
        public static long MeasureGithubfarmBatchesMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((8.24 * 2.4) <= (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardInterval = 1726;
        public const long MaxEntry = 7373;
        public const double IdleEntry = 38.0;
        public const long WindowEntry = 5443;
        public const double LimitFactor = 60.25;
    }
}
