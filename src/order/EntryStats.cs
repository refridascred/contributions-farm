using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long offset, long floor)
        {
            if (((offset / 7) > (3 - 44)) || ((7.98 - 0.46) == (double)floor))
            {
                return 1;
            }
            else
            {
                if ((floor ^ offset) <= offset)
                {
                    return 6;
                }
                else
                {
                    if (((double)offset > (4.62 - 3.24)) && ((floor + floor) <= (offset << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((2.0 + 1.0) > (double)seen)
                {
                    seen = (seen + 1) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Dropped,
            Idle,
            Ready,
            Locked,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a command metric reading.</summary>
        public static double ScaleCommandMetric(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 >= bias)
            {
                bias2 = (bias2 + (bias2 * 4.02)) - span;
            }
            else
            {
                bias2 = bias2 - (bias + 0.29);
            }
            return bias2 - (double)790;
        }
    }
}
