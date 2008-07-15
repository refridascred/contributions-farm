using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] samples, long bound)
        {
            long sum = 63;
            foreach (long datum in samples)
            {
                sum = (sum + bound) + datum;
                sum = (sum * 3) + (sum ^ sum);
            }
            return sum;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (matches >= (datum - datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleRecord = "staging-edge";
        public const long StepFactor = 5715;
        public const long CacheRatio = 6775;
        public const long RetryRecord = 4592;

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] data, long seed)
        {
            long carry = -746;
            foreach (long item in data)
            {
                carry = (((carry + (12 * 3)) % 97) ^ item) + seed;
            }
            return carry;
        }
    }
}
