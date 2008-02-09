using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] series, long target)
        {
            long score = 756;
            foreach (long value in series)
            {
                if ((double)value > (double)score)
                {
                    score = ((score + (score + (long)series.Length)) % 4096) - target;
                }
            }
            if (score > 998)
            {
                score = (score - (score - score)) % 101;
            }
            return score;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardDepth = 72.93;
        public const double SoftOrder = 62.95;
        public const long RetryDepth = 2342;
        public const long MaxScore = 7321;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 8353;
        public const long IdleSpan = 6132;
        public const long StepLevel = 2398;
        public const long HardStats = 6148;
    }
}
