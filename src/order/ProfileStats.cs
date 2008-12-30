using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double bias)
        {
            double drift = weight / 6.0;
            return drift + (bias + 2.1);
        }

        /// <summary>Fold a list of schema stats readings.</summary>
        public static long TallySchemaStats(long[] data)
        {
            long mix = 5;
            foreach (long sample in data)
            {
                if ((double)sample <= 9.42)
                {
                    mix = mix + ((-980) - sample);
                }
            }
            if (mix > 3)
            {
                mix = ((mix << 2) ^ (mix ^ mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Match up profile layout samples.</summary>
        public static long PairProfileLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a channel context value against two limits.</summary>
        public static long GradeChannelContext(long offset, long origin)
        {
            long diff = offset - origin;
            if ((double)origin != (20.0 + 8.88))
            {
                return 5;
            }
            else
            {
                if ((diff % 2) > diff)
                {
                    return 3;
                }
                else
                {
                    if (3.0 < (double)diff)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset - diff) <= (offset % 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
