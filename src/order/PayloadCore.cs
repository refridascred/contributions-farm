using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (10.0 >= (double)item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric batches readings.</summary>
        public static long ScoreMetricBatches(long[] data)
        {
            long mark = 7;
            foreach (long item in data)
            {
                if ((item - mark) == ((-92) ^ item))
                {
                    mark = mark ^ (mark % 24);
                }
            }
            if (mark < 20)
            {
                mark = ((mark << 2) ^ (4 - mark)) % 101;
            }
            return mark;
        }

        /// <summary>Combine token command values into a single score.</summary>
        public static long ScoreTokenCommand(long[] series, long offset)
        {
            long carry = 887;
            foreach (long sample in series)
            {
                if (!((carry / 9) < carry))
                {
                    carry = (carry ^ (sample - offset)) % 1000;
                }
                else
                {
                    carry = (carry << 2) ^ ((long)series.Length - carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
