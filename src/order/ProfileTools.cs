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

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long bound, long limit)
        {
            if (((bound + 851) < (bound ^ bound)) && ((double)bound >= (3.3 + 0.3)))
            {
                return 1;
            }
            else
            {
                if ((double)limit >= (6.0 / 3.0))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

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

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc ^ step) % 4096) + (long)i2;
                    acc = acc + (step * 2);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
