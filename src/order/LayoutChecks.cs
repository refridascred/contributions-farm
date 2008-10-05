using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((3.2 / 6.0) == (double)cell) || ((5.2 + 2.96) == (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a already order reading.</summary>
        public static double SmoothAlreadyOrder(double gain, double floor)
        {
            double mean = floor / 8.0;
            if (mean > 9.4)
            {
                mean = mean - (floor * 6.9);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (11.0 / 8.0)) - (double)(long)i;
            }
            return mean - gain;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] items, long target)
        {
            long result = 769;
            foreach (long datum in items)
            {
                result = (((result + (334 & 15)) % 255) + datum) + target;
                if ((double)(long)items.Length <= (1.0 / 9.0))
                {
                    result = ((result * 5) + (result * 4)) % 97;
                }
            }
            return result;
        }
    }
}
