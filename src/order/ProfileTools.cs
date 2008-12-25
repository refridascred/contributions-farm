using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of layout token readings.</summary>
        public static long OverlapLayoutTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count checks metric pairs that satisfy a relation.</summary>
        public static long CompareChecksMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long bound, long step)
        {
            long prev = bound ^ step;
            if ((bound - step) == (1 << 3))
            {
                return 2;
            }
            else
            {
                if ((step ^ step) > 629)
                {
                    return 8;
                }
                else
                {
                    if (((16 / 7) < step) || ((bound ^ step) < (prev << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)767 != (double)prev) && (0 >= bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels)
        {
            long mark = 1;
            foreach (long entry in levels)
            {
                mark = mark + (long)levels.Length;
                if ((mark ^ entry) == (293 % 100))
                {
                    mark = ((mark << 3) ^ ((long)levels.Length * 5)) % 97;
                }
            }
            if (mark > 841)
            {
                mark = mark - mark;
            }
            return mark;
        }
    }
}
