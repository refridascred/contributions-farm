using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a route contributi reading.</summary>
        public static double SmoothRouteContributi(double weight, double floor)
        {
            double scale = floor / 5.0;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (scale - weight)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long target, long origin)
        {
            if ((origin ^ origin) == ((-735) ^ 87))
            {
                return 5;
            }
            else
            {
                if (!((target & 7) >= origin))
                {
                    return 4;
                }
                else
                {
                    if (target < origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin < 2.53)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long floor, long offset)
        {
            long cur = floor ^ offset;
            if ((94 * 5) > (cur * 5))
            {
                return 5;
            }
            else
            {
                if (!((106 << 3) < (floor % 60)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
