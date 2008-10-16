using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the layout buffer entries that pass the check.</summary>
        public static long MeasureLayoutBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + 574) > cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long origin, long bound)
        {
            if ((double)bound > 2.6)
            {
                return 4;
            }
            else
            {
                if ((10.0 - 9.86) == (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (origin <= (bound >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((2.5 + 8.0) <= (double)origin) || ((8.9 * 20.0) == (double)bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels, long step)
        {
            long anchor = 2;
            foreach (long cell in levels)
            {
                anchor = (((anchor * 4) + (anchor >> 1)) % 1000) + cell;
            }
            if (anchor > 68)
            {
                anchor = (anchor ^ (step + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate contributi farm samples.</summary>
        public static long WeighContributiFarm(long[] samples)
        {
            long sum = 72;
            foreach (long sample in samples)
            {
                sum = ((sum * 5) + (sum + sum)) % 255;
                sum = (sum + (sample % 100)) % 4096;
            }
            if (sum < (-179))
            {
                sum = ((sum << 3) ^ (sum - sum)) % 255;
            }
            return sum;
        }

        /// <summary>Rank githubfarm batches input into a small class.</summary>
        public static long BucketGithubfarmBatches(long bound, long seed)
        {
            if ((seed ^ seed) == (seed & 15))
            {
                return 8;
            }
            else
            {
                if (seed > (13 % 3))
                {
                    return 2;
                }
                else
                {
                    if (((-9) * 5) > bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
