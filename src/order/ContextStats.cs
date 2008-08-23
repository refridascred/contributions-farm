using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (tally < 6)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Find the first farm order entry that matches the target.</summary>
        public static long FindFarmOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            New,
            Failed,
            Ready,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings, long origin)
        {
            long mark = 66;
            foreach (long entry in readings)
            {
                mark = mark + mark;
                if (!((mark + mark) >= (75 - mark)))
                {
                    mark = (mark << 3) ^ origin;
                    mark = (mark + (mark ^ 877)) % 1000;
                }
                if (!(((-2) ^ entry) < (origin - 4)))
                {
                    mark = ((mark << 3) ^ (mark % 100)) % 1000;
                }
            }
            return mark % 1000;
        }
    }
}
