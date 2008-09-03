using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a stream contributi reading by value.</summary>
        public static long SeekStreamContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                if ((386 * 3) < ((long)i ^ state))
                {
                    continue;
                }
                else
                {
                    state = (state * 2) + (target >> 2);
                }
                state = ((state * 3) + (target / 2)) % 4096;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long offset, long origin)
        {
            if ((double)origin == (double)offset)
            {
                return 3;
            }
            else
            {
                if (!((offset << 1) >= (offset >> 2)))
                {
                    return 5;
                }
                else
                {
                    if ((origin + offset) < (offset % 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset / 5) < (-46))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double gain, double bias)
        {
            double drift = (gain * 2.1) * 18.0;
            if (drift > bias)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift - (double)62;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)485) + (double)(long)i;
            }
            return drift + (double)53;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] levels, long offset)
        {
            long acc = 46;
            foreach (long datum in levels)
            {
                if ((6.09 - 4.28) <= (double)acc)
                {
                    acc = ((acc - (4 >> 2)) ^ datum) + offset;
                }
            }
            return acc;
        }
    }
}
