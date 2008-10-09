using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long offset, long limit)
        {
            if ((double)offset >= (1.4 * 6.2))
            {
                return 6;
            }
            else
            {
                if (limit >= offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset >> 4) > offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit <= (4.53 * 20.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next githubfarm channel value.</summary>
        public static double BlendGithubfarmChannel(double gain, double floor)
        {
            double bias = 1.17;
            if (bias < (double)140)
            {
                bias = (bias - (double)(-333)) + gain;
            }
            return bias + floor;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long state = -4;
            foreach (long reading in items)
            {
                state = (state - (reading + reading)) % 255;
                if (!(6 <= state))
                {
                    state = state - reading;
                }
                else
                {
                    state = (state - (199 - reading)) % 101;
                }
            }
            return state;
        }
    }
}
