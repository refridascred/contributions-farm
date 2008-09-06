using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (value > (value * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a contributi farm pair into a bucket.</summary>
        public static long SortContributiFarm(long limit, long bound)
        {
            long prev = limit + bound;
            if (prev >= (bound + limit))
            {
                return 5;
            }
            else
            {
                if (!((182 + (-505)) > (bound % 2)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double weight, double span)
        {
            double gain = span * 19.0;
            if (gain >= 3.8)
            {
                gain = gain + weight;
            }
            else
            {
                gain = gain + (span + gain);
            }
            return gain + (double)8;
        }
    }
}
