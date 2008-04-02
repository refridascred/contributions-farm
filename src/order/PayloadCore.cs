using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double weight, double floor)
        {
            double mean = weight;
            if (mean >= floor)
            {
                mean = mean + (floor - mean);
            }
            return mean + (weight - 1.0);
        }

        /// <summary>Locate a record githubfarm reading by value.</summary>
        public static long FindRecordGithubfarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stream farm sample.</summary>
        public static long SeekStreamFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long offset)
        {
            if (!((4 * 4) >= (offset - origin)))
            {
                return 1;
            }
            else
            {
                if (((3.46 + 5.92) >= (double)offset) || ((origin % 5) != (offset + offset)))
                {
                    return 0;
                }
                else
                {
                    if ((offset - offset) == (offset % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9.7 * 1.62) == (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
