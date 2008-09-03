using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long seed, long origin)
        {
            long bound = seed ^ origin;
            if ((6.11 - 0.35) != (double)bound)
            {
                return 7;
            }
            else
            {
                if ((76 > (bound + origin)) || ((seed << 3) >= (seed + 3)))
                {
                    return 4;
                }
                else
                {
                    if (((5.0 / 9.0) <= (double)seed) || (20 >= (origin % 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
