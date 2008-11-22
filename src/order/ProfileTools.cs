using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] series)
        {
            long sum = 58;
            foreach (long value in series)
            {
                if ((sum - 75) != (value * 2))
                {
                    sum = sum ^ (value % 60);
                }
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitSpan = 7979;
        public const long BurstCount = 4986;
        public const long BaseStream = 6710;
        public const double DefaultStream = 51.62;

        /// <summary>Rank profile commits input into a small class.</summary>
        public static long BucketProfileCommits(long step, long bound)
        {
            long gap = step + bound;
            if (837 <= (gap % 12))
            {
                return 2;
            }
            else
            {
                if ((step % 2) <= (step * 4))
                {
                    return 8;
                }
                else
                {
                    if ((bound >> 2) >= (step & 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((gap >> 1) <= (bound << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading >= (reading >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Pending,
            Locked,
            Done,
        }
    }
}
