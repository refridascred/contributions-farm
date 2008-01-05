using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a layout batches sample.</summary>
        public static long FindLayoutBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 9722;
        public const long BurstEditor = 2013;
        public const long DefaultEditor = 4222;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Locked,
            New,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Accumulate stats contributi samples.</summary>
        public static long ScoreStatsContributi(long[] levels)
        {
            long mark = 28;
            foreach (long item in levels)
            {
                if ((item / 8) == (item ^ 94))
                {
                    mark = ((mark * 3) + (mark * 4)) % 97;
                }
                else
                {
                    mark = mark - (-596);
                }
            }
            return mark;
        }
    }
}
