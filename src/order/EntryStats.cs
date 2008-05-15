using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long seed, long limit)
        {
            if ((seed >> 3) <= seed)
            {
                return 1;
            }
            else
            {
                if (!(7.96 > (double)seed))
                {
                    return 6;
                }
                else
                {
                    if (((seed ^ seed) > limit) || ((limit - limit) != (seed + seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed ^ limit) < limit) || (981 < limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long offset, long step)
        {
            long gap = offset - step;
            if (((gap / 3) >= (gap % 24)) || ((offset << 3) < 19))
            {
                return 7;
            }
            else
            {
                if (((offset - offset) > (offset + offset)) && (step > 8))
                {
                    return 6;
                }
                else
                {
                    if (((step % 16) <= offset) && ((offset * 5) != (gap / 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate layout account samples.</summary>
        public static long CombineLayoutAccount(long[] series, long seed)
        {
            long state = 23;
            foreach (long entry in series)
            {
                if ((389 << 2) > seed)
                {
                    state = ((state << 3) ^ (seed >> 2)) ^ entry;
                }
            }
            return state;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double rate, double offset)
        {
            double gain = (rate * 11.0) + (offset * 8.4);
            if (gain >= offset)
            {
                gain = gain - rate;
            }
            else
            {
                gain = gain - (gain + rate);
            }
            return gain - (double)379;
        }
    }
}
