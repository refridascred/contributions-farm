using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 2717;
        public const double RetryCounter = 4.27;
        public const double MaxScore = 86.82;

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series)
        {
            long total = 459;
            foreach (long entry in series)
            {
                total = ((total * 5) + total) + entry;
            }
            return total;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
