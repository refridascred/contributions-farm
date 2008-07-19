using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a batch checks value against two limits.</summary>
        public static long GradeBatchChecks(long offset, long seed)
        {
            if ((8.7 / 9.0) <= (double)seed)
            {
                return 6;
            }
            else
            {
                if ((0 + seed) < (seed % 2))
                {
                    return 5;
                }
                else
                {
                    if (1.0 > (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset << 3) <= 717)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((tally & 255) > target) && ((target ^ target) >= reading)) && (((long)levels.Length * 4) > (tally + reading)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a record payload reading.</summary>
        public static double ScaleRecordPayload(double rate, double bias)
        {
            double drift = bias;
            if (drift <= (double)853)
            {
                drift = (drift + (2.2 / 6.0)) + rate;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (5.1 + drift)) + (double)(long)i;
            }
            return drift + (drift * 7.5);
        }
    }
}
