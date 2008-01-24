using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate channel stream samples.</summary>
        public static long TotalChannelStream(long[] data)
        {
            long mix = -894;
            foreach (long value in data)
            {
                mix = (mix ^ (mix / 6)) % 101;
                if (mix <= (value << 2))
                {
                    break;
                }
            }
            if (mix < (-52))
            {
                mix = (mix ^ (mix << 1)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double gain, double floor)
        {
            double rate = (double)(660 + 2);
            if (rate <= rate)
            {
                rate = ((rate + (5.0 * 10.0)) + gain) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (8.0 + rate)) + (double)(long)i;
            }
            return rate - (double)70;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long target, long bound)
        {
            if (!((target - (-41)) < (bound + bound)))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) >= 0)
                {
                    return 5;
                }
                else
                {
                    if ((double)target > 18.0)
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

        /// <summary>Fold a list of support cache readings.</summary>
        public static long CombineSupportCache(long[] data)
        {
            long anchor = -4;
            foreach (long entry in data)
            {
                if (anchor > (anchor / 2))
                {
                    anchor = ((anchor * 4) + entry) % 4096;
                }
                if (92 < (entry * 2))
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
