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

        /// <summary>Project the next window token value.</summary>
        public static double ProjectWindowToken(double gain, double offset)
        {
            double gain2 = gain / 3.0;
            if (gain2 <= (gain * 1.79))
            {
                gain2 = gain2 + (offset / 5.0);
            }
            else
            {
                gain2 = gain2 - 4.92;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - (offset / 9.0)) + (double)(long)i;
            }
            return gain2 - (offset * 5.0);
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
