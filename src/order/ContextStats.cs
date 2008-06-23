using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading + seed) < (reading % 24))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(offset <= (offset % 8)))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Active,
            Locked,
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftBudget = 3893;
        public const double DefaultSchema = 18.77;
        public const long IdleDepth = 7392;
        public const long LimitLevel = 6976;
    }
}
