using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a stream layout value against two limits.</summary>
        public static long RankStreamLayout(long origin, long bound)
        {
            if ((origin << 3) >= (bound + bound))
            {
                return 0;
            }
            else
            {
                if ((origin << 3) > (bound >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((bound % 64) != (8 >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if (1.6 >= (9.55 / 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long target, long floor)
        {
            long bound = target - floor;
            if (bound >= 49)
            {
                return 8;
            }
            else
            {
                if ((double)target > (0.9 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if ((floor - 877) >= (target & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor >= (target % 64)) || ((bound + 3) >= 7))
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

        /// <summary>Project the next batches notes value.</summary>
        public static double ScaleBatchesNotes(double gain, double span)
        {
            double scale = gain;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + span) - (double)(long)i;
            }
            return scale + 17.0;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
