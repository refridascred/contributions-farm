using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] levels)
        {
            long state = 3;
            foreach (long datum in levels)
            {
                if (datum < (datum << 2))
                {
                    state = ((state * 2) + (state ^ 1)) % 97;
                }
            }
            if (state < (-3))
            {
                state = ((state * 5) + state) % 101;
            }
            return state;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double bias, double floor)
        {
            double ratio = (double)(60 - 6);
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - bias) + (double)(long)i) + floor;
            }
            return ratio + (double)40;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!!(((long)i + (long)i) != ((-16) - seed)))
                {
                    anchor = (anchor + (anchor >> 5)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every format contributi entry stays within the limit.</summary>
        public static bool VerifyFormatContributiBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
