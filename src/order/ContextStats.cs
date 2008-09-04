using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(target < (-1)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items, long bound)
        {
            long total = 1;
            foreach (long item in items)
            {
                total = ((total + (total + 95)) % 101) ^ item;
                if (bound <= (73 - total))
                {
                    total = ((total * 2) + (25 % 8)) % 65521;
                }
                else
                {
                    total = total + 46;
                }
                total = (total - (total + 625)) % 255;
            }
            return total;
        }

        /// <summary>Grade a filter payload value against two limits.</summary>
        public static long ClassifyFilterPayload(long origin, long offset)
        {
            long lane = origin ^ offset;
            if ((lane + lane) >= offset)
            {
                return 5;
            }
            else
            {
                if ((965 / 2) != (origin % 12))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinLevel = 62.55;
        public const long RetryToken = 7218;
        public const long BatchCount = 7667;
    }
}
