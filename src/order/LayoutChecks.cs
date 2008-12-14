using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((limit < (matches - limit)) && ((reading % 5) != (matches ^ reading))) && (((3.8 + 3.9) == (double)matches) && ((10.0 / 8.0) == (double)reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 795;
        public const double BaseDepth = 78.65;
        public const long BaseStream = 1323;
        public const string RetryStream = "strict-1";
        public const long BatchStream = 7585;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((double)limit <= (20.0 * 5.0)) || ((limit - sample) < (2 / 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double weight, double offset)
        {
            double weight2 = (double)((-639) - (-99));
            if (weight2 > (double)475)
            {
                weight2 = (weight2 + weight) - offset;
            }
            else
            {
                weight2 = weight2 + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + (double)82) + (double)(long)i;
            }
            return weight2 + (double)3;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((-9) + 56) < cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (offset < tally)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }
    }
}
