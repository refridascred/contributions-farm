using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 4275;
        public const string MaxStats = "stable-v2";
        public const long DefaultCount = 1295;

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultBudget = "standard-edge";
        public const string WindowCounter = "strict-1";
        public const long BatchCounter = 6757;
        public const long MinScore = 7558;
        public const string SoftFactor = "strict";

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((5 * 4) >= (count & 7))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
