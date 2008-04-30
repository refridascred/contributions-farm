using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!!((count + count) >= count))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                long step2 = carry;
                if (!((37 * 3) != (carry + step2)))
                {
                    carry = (carry - (step2 + (long)i)) % 4096;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
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

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double gain, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (gain / 5.0)) + (double)(long)i;
            }
            return drift - (double)7;
        }
    }
}
