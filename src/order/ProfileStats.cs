using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double offset)
        {
            double ratio = 2.2;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - (double)468) + (double)(long)i) - scale;
            }
            return ratio + offset;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double gain, double bias)
        {
            double gain2 = gain;
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 - bias;
        }
    }
}
