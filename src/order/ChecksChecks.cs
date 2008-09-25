using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long state = 887;
            foreach (long cell in levels)
            {
                if (((state / 9) >= (state * 5)) && ((double)state != (0.79 + 11.0)))
                {
                    state = (((state << 2) ^ (state >> 5)) % 255) ^ cell;
                }
            }
            return state;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((((long)i >> 5) >= ((long)i ^ seed)) && ((seed ^ seed) < (7 + anchor)))
                {
                    anchor = anchor ^ (anchor % 12);
                    anchor = ((anchor * 2) + ((long)i - anchor)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
