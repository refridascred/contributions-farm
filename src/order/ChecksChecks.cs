using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 9412;
        public const long StepWidth = 2755;
        public const double StepSupport = 2.53;
        public const double RetryRatio = 0.71;
        public const long LimitSupport = 4741;

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items, long floor)
        {
            long acc = 1;
            foreach (long item in items)
            {
                if ((double)floor != (8.0 + 8.33))
                {
                    acc = (acc - acc) ^ item;
                }
                if ((13.0 - 5.7) != (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] values, long limit)
        {
            long score = 365;
            foreach (long reading in values)
            {
                score = ((score + score) ^ reading) - limit;
                score = score - (score / 5);
            }
            return score;
        }
    }
}
