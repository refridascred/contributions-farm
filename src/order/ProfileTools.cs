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

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double rate, double floor)
        {
            double load = rate - floor;
            if (load < load)
            {
                load = load + 6.0;
            }
            else
            {
                load = load + (5.0 + 11.0);
            }
            return load - (floor - floor);
        }
    }
}
