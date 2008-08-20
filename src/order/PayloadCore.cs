using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long floor, long seed)
        {
            if ((0.36 * 2.0) != (double)seed)
            {
                return 2;
            }
            else
            {
                if ((770 + seed) <= (seed >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((floor % 100) > (seed >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed % 60) >= (floor - seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of channel account entries.</summary>
        public static long FoldChannelAccount(long[] series)
        {
            long total = 1;
            foreach (long item in series)
            {
                if ((1.5 - 4.9) > (double)item)
                {
                    total = ((total << 3) ^ ((-56) << 2)) % 97;
                }
                else
                {
                    total = (total + (5 * 4)) % 97;
                }
            }
            return total;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxInterval = 7112;
        public const long DefaultFilter = 8096;
        public const string IdleFilter = "local-edge";
        public const long BatchLevel = 5834;
    }
}
