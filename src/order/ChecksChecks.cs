using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((8.56 * 1.0) > (double)state) && (37 > state))
                {
                    state = ((state << 2) ^ (30 >> 5)) % 255;
                    state = (state - state) % 101;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double offset)
        {
            double gain = offset + weight;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (double)41;
        }
    }
}
