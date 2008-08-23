using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((datum - matches) <= (matches + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank notes contributi input into a small class.</summary>
        public static long ClassifyNotesContributi(long origin, long offset)
        {
            if ((origin / 5) != (origin * 2))
            {
                return 5;
            }
            else
            {
                if (((double)offset > (double)50) && ((double)offset <= (12.0 + 3.77)))
                {
                    return 3;
                }
                else
                {
                    if (((7.5 - 8.63) >= (double)origin) || ((offset / 8) == (offset / 6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((-86) <= origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFactor = 7601;
        public const string BurstRatio = "local";
        public const long DefaultFilter = 5234;
        public const double WindowFactor = 92.22;
        public const long WindowInterval = 5904;

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double scale, double offset)
        {
            double rate = offset - offset;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate - offset;
        }
    }
}
