using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] data, long seed)
        {
            long carry = 0;
            foreach (long sample in data)
            {
                carry = (carry + (sample * 5)) + seed;
            }
            return carry % 65521;
        }

        /// <summary>Look up the position of a buffer githubfarm sample.</summary>
        public static long LookupBufferGithubfarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] samples, long step)
        {
            long score = 59;
            foreach (long reading in samples)
            {
                score = (score + (step >> 5)) ^ reading;
            }
            return score;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] levels, long step)
        {
            long mark = 1;
            foreach (long item in levels)
            {
                mark = ((mark - (step * 3)) % 255) - item;
            }
            if (mark > 785)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long target, long target2)
        {
            long delta = target - target2;
            if ((5.97 - 8.14) <= (double)target2)
            {
                return 1;
            }
            else
            {
                if (target <= (target / 8))
                {
                    return 7;
                }
                else
                {
                    if ((79 >> 2) == (delta + delta))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)delta < (1.05 + 8.8)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
