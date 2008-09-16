using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long bound)
        {
            if ((double)origin == (8.19 + 11.0))
            {
                return 3;
            }
            else
            {
                if ((8.97 / 2.0) >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (254 >= bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound << 3) < (0 >> 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] levels, long offset)
        {
            long state = 0;
            foreach (long reading in levels)
            {
                state = (state - offset) % 101;
                state = ((state << 3) ^ (527 & 1)) % 97;
                state = (state ^ (offset << 3)) % 101;
                if ((reading / 5) >= (state - reading))
                {
                    break;
                }
            }
            if (state > 46)
            {
                state = (state ^ (offset % 12)) % 101;
            }
            return state;
        }

        /// <summary>Measure how many counter githubfarm samples are out of range.</summary>
        public static long TallyCounterGithubfarmGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((3.73 - 13.0) < (double)count) && ((long)samples.Length >= step)) || ((6.0 * 2.9) < (13.0 + 7.7)))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
