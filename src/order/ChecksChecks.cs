using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long seed, long target)
        {
            long offset = seed - target;
            if ((13.0 + 3.0) == (double)seed)
            {
                return 0;
            }
            else
            {
                if ((8.0 / 3.0) != (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (!(19 < (offset + seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long floor)
        {
            long bound = limit - floor;
            if (2.4 > (double)bound)
            {
                return 7;
            }
            else
            {
                if ((floor % 7) > (178 + bound))
                {
                    return 4;
                }
                else
                {
                    if ((79 % 97) > limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
