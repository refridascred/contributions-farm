using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 2938;
        public const string MaxScore = "legacy-1";
        public const long StepLevel = 5651;
        public const double MaxCache = 44.42;
        public const double IdleWidth = 25.09;

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items)
        {
            long acc = 8;
            foreach (long cell in items)
            {
                if (170 > (acc - cell))
                {
                    acc = ((acc * 4) + (cell + cell)) % 1000;
                }
                else
                {
                    acc = (acc + cell) % 65521;
                }
            }
            return acc % 97;
        }
    }
}
