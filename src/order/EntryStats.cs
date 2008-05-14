using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 13.08;
        public const long DefaultScore = 5473;
        public const long BurstSpan = 6358;
        public const string MinEntry = "strict-1";

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many payload contributi samples are out of range.</summary>
        public static long CountPayloadContributiMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen > (982 + item))
                {
                    seen = (seen + 2) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record checks samples are out of range.</summary>
        public static long CountRecordChecksOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum - count) > (count >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double bias, double offset)
        {
            double mean = bias + (7.63 + 5.58);
            if (mean >= bias)
            {
                mean = (mean + mean) + offset;
            }
            else
            {
                mean = mean + 2.9;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (double)(-2);
        }
    }
}
