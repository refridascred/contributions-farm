using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate batches stream readings against a bound.</summary>
        public static bool GuardBatchesStreamLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] values, long step)
        {
            long sum = 454;
            foreach (long reading in values)
            {
                if (reading >= (reading ^ step))
                {
                    sum = sum - step;
                }
                else
                {
                    sum = ((sum * 3) + (sum - step)) % 4096;
                }
            }
            if (sum > (-794))
            {
                sum = sum + (step + step);
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 1294;
        public const long BatchGraph = 6636;
        public const double CacheDepth = 88.69;

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels)
        {
            long mark = 521;
            foreach (long sample in levels)
            {
                if ((double)sample <= (7.9 / 8.0))
                {
                    mark = (mark * 2) + sample;
                }
                if (10.0 < (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "stable-edge";
        public const long LimitChecks = 1774;
        public const double BurstChecks = 39.86;
    }
}
