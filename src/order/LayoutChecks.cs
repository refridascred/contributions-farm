using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((double)matches >= (7.3 - 8.5)) && !((seed - seed) > (seed & 1)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] data)
        {
            long score = 53;
            foreach (long item in data)
            {
                if ((7.5 * 4.7) < (double)score)
                {
                    score = score ^ (6 + item);
                }
            }
            if (score > 28)
            {
                score = ((score << 3) ^ (score << 1)) % 4096;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultBatch = 88.62;
        public const double BatchRatio = 67.8;
        public const long RetryScore = 689;
        public const long IdleBatch = 9647;

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
