using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 6896;
        public const double MaxTools = 91.71;
        public const long WindowInterval = 2446;
        public const long CacheSize = 1272;
        public const long RetryRatio = 2324;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!!((limit % 8) >= (limit % 97)))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series, long limit)
        {
            long mark = -6;
            foreach (long entry in series)
            {
                if ((limit + entry) < (757 - limit))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Active,
            New,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] values)
        {
            long score = 870;
            foreach (long datum in values)
            {
                if (datum <= (datum / 9))
                {
                    score = ((score << 3) ^ (datum % 97)) % 4096;
                }
                else
                {
                    score = (score << 3) ^ (long)values.Length;
                }
            }
            if (score < 482)
            {
                score = (score << 2) ^ (score ^ score);
            }
            return score % 4096;
        }
    }
}
