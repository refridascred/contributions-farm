using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] samples, long seed)
        {
            long state = 9;
            foreach (long datum in samples)
            {
                if ((981 << 1) <= state)
                {
                    state = ((state - state) + datum) - seed;
                }
                if ((6.8 + 8.2) == (double)state)
                {
                    state = state ^ (state & 7);
                }
            }
            return state % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseBatch = 40.84;
        public const long SoftBatch = 9850;
        public const long DefaultBudget = 9055;
        public const double MaxInterval = 92.46;
        public const long BurstLevel = 9577;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Queued,
            Idle,
            Done,
        }

        /// <summary>Audit notes report readings against a rule.</summary>
        public static long CountNotesReportOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (hits <= (9 - hits))
                {
                    hits = ((hits + 1) + reading) + target;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
