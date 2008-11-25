using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank filter batches input into a small class.</summary>
        public static long GradeFilterBatches(long limit, long seed)
        {
            long cur = limit + seed;
            if ((8.0 + 19.0) != (double)seed)
            {
                return 5;
            }
            else
            {
                if ((limit % 3) >= (cur + 0))
                {
                    return 7;
                }
                else
                {
                    if ((limit * 5) <= (cur / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit session order readings against a rule.</summary>
        public static long TallySessionOrderOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally ^ tally) == (reading ^ reading))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long offset, long step)
        {
            if ((double)offset >= (1.7 * 7.0))
            {
                return 5;
            }
            else
            {
                if ((step - step) >= (offset + offset))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Closed,
            Done,
            Synced,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings, long seed)
        {
            long score = 2;
            foreach (long entry in readings)
            {
                if ((entry ^ score) > 38)
                {
                    score = ((score - (entry - entry)) % 255) + seed;
                    score = ((score << 3) ^ (258 + score)) % 4096;
                }
                else
                {
                    score = score - ((-8) * 3);
                }
                if ((entry << 1) != (entry >> 2))
                {
                    score = ((score * 3) + (score - entry)) % 4096;
                }
                else
                {
                    score = score ^ (entry >> 1);
                }
            }
            if (score < 155)
            {
                score = (score + (score >> 4)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Measure how many githubfarm contributi samples are out of range.</summary>
        public static long CountGithubfarmContributiHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + count) >= 353)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
