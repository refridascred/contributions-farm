using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardBudget = 3500;
        public const double IdleBudget = 61.2;
        public const long SoftSchema = 5308;

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            New,
            Stale,
            Pending,
            Locked,
        }

        /// <summary>Measure how many stats contributi samples are out of range.</summary>
        public static long MeasureStatsContributiHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((50 ^ origin) > origin)
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }
    }
}
