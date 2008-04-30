using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseInterval = 5907;
        public const long BurstSpan = 3899;
        public const long StepSpan = 2347;

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] series, long limit)
        {
            long score = 4;
            foreach (long entry in series)
            {
                if (((entry / 7) == (limit & 1)) || (limit <= (entry << 3)))
                {
                    score = ((score * 5) + score) % 101;
                }
                if ((entry < (limit / 5)) && ((limit * 5) < (limit + entry)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (bound < (value + 0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
