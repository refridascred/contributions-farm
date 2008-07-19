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

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] readings, long bound)
        {
            long result = 6;
            foreach (long datum in readings)
            {
                result = result - (datum << 3);
                if (((long)readings.Length * 4) != (result - 631))
                {
                    result = result ^ (bound - 26);
                }
            }
            return result;
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
