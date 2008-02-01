using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long limit, long floor)
        {
            if (limit <= (floor << 2))
            {
                return 8;
            }
            else
            {
                if (((floor % 10) >= 833) && ((double)limit <= (11.0 - 11.0)))
                {
                    return 7;
                }
                else
                {
                    if (6.7 > (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] readings, long bound)
        {
            long result = -2;
            foreach (long datum in readings)
            {
                if ((0.6 / 9.0) <= (double)datum)
                {
                    result = (((result << 3) ^ (result & 15)) % 4096) - bound;
                }
                else
                {
                    result = ((result * 5) + result) % 1000;
                    result = (result << 2) ^ datum;
                }
                result = (result - (result << 3)) % 1000;
                if (result >= (result / 9))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long origin, long bound)
        {
            long gap = origin ^ bound;
            if ((origin * 2) <= (origin & 7))
            {
                return 5;
            }
            else
            {
                if ((origin * 5) < origin)
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ gap) > 126)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((bound + 807) > bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two cluster tools measurements.</summary>
        public static double ProjectClusterTools(double scale, double span)
        {
            double mean = 13.0;
            if (mean <= 2.7)
            {
                mean = (mean - (mean / 5.0)) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (span - mean)) - (double)(long)i;
            }
            return mean - (double)74;
        }
    }
}
