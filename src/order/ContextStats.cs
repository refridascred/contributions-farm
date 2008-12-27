using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Draft,
            Active,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long floor, long seed)
        {
            if ((seed % 100) >= (seed ^ 1))
            {
                return 0;
            }
            else
            {
                if ((floor * 3) >= (floor * 5))
                {
                    return 6;
                }
                else
                {
                    if (411 <= (floor >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((5.0 - 19.0) > (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double ratio, double offset)
        {
            double rate = ratio;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate + (double)21;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
