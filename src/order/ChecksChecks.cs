using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double bias)
        {
            double scale = gain;
            if (scale <= (gain * 11.0))
            {
                scale = scale - 9.0;
            }
            else
            {
                scale = scale + (double)2;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (bias * 6.88)) + (double)(long)i;
            }
            return scale - gain;
        }
    }
}
