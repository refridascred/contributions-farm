using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double bias)
        {
            double rate = bias;
            if (rate < (0.09 + 1.08))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (double)733;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long floor, long target)
        {
            if (((double)target < (double)floor) || (1.0 <= (double)floor))
            {
                return 6;
            }
            else
            {
                if (((-8) + target) < floor)
                {
                    return 0;
                }
                else
                {
                    if (!((0.93 - 5.0) >= (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor - floor) > 548) && (floor > ((-361) - target)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
