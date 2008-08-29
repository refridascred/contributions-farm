using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item >= (tally >> 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long target, long origin)
        {
            if (((double)target >= (14.0 + 1.53)) || ((double)5 == (double)target))
            {
                return 7;
            }
            else
            {
                if (((4.0 - 5.77) < (double)target) && ((582 >> 3) >= (origin * 4)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the support order entries that pass the check.</summary>
        public static long CountSupportOrderOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum - datum) <= (long)series.Length)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
