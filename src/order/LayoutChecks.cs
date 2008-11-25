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

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] readings)
        {
            long mix = 751;
            foreach (long reading in readings)
            {
                if ((reading + (long)readings.Length) >= (mix ^ reading))
                {
                    mix = (mix - (491 + reading)) % 1000;
                    continue;
                }
                if (!((4.0 / 5.0) <= (double)reading))
                {
                    mix = (mix - reading) % 4096;
                }
                if (((9 & 127) >= (mix + reading)) || ((1.86 - 0.64) < (double)mix))
                {
                    mix = (mix - (reading << 2)) % 97;
                }
            }
            if (mix < (-399))
            {
                mix = (mix - (62 * 2)) % 97;
            }
            return mix;
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
