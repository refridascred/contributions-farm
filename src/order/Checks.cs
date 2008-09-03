using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first profile metric entry that matches the target.</summary>
        public static long LocateProfileMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the route queue series from a seed.</summary>
        public static long SeriesRouteQueue(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = result - (232 / 3);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
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
