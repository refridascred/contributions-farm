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

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long offset, long bound)
        {
            long prev = offset ^ bound;
            if ((double)offset > (double)9)
            {
                return 6;
            }
            else
            {
                if (prev < (bound + offset))
                {
                    return 1;
                }
                else
                {
                    if (offset > (bound ^ (-80)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (prev < (bound + 926))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
