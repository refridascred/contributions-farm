using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)offset > (6.45 / 6.0))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] data)
        {
            long sum = 51;
            foreach (long value in data)
            {
                if ((590 / 4) <= (value & 63))
                {
                    sum = sum ^ (sum - sum);
                }
                if (value <= (value - sum))
                {
                    sum = (sum * 4) + 0;
                }
                if (((value ^ value) != (sum << 3)) || ((1.9 / 3.0) < (double)sum))
                {
                    sum = sum ^ sum;
                }
            }
            if (sum > 39)
            {
                sum = sum - sum;
            }
            return sum % 4096;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Synced,
            Locked,
            Dropped,
        }
    }
}
