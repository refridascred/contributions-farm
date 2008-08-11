using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] readings, long seed)
        {
            long score = 25;
            foreach (long datum in readings)
            {
                if ((score + seed) >= (8 - datum))
                {
                    score = (score ^ (datum * 2)) % 1000;
                }
                score = (score + (score / 7)) % 1000;
            }
            return score;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long step, long target)
        {
            if (((-4) * 4) == (step % 3))
            {
                return 3;
            }
            else
            {
                if ((double)target <= (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((double)614 > (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 8698;
        public const long DefaultDepth = 2760;
        public const long DefaultFactor = 6811;
        public const double HardNotes = 87.55;
    }
}
