using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long origin, long seed)
        {
            long offset = origin - seed;
            if (((origin - origin) != (offset >> 2)) || ((2.79 / 7.0) == (double)offset))
            {
                return 4;
            }
            else
            {
                if ((offset * 2) >= origin)
                {
                    return 2;
                }
                else
                {
                    if (((double)origin <= (6.1 * 0.1)) && ((origin + 0) >= (offset + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset > (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 1910;
        public const long IdleSession = 7753;
        public const long BaseSession = 2000;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double scale, double bias)
        {
            double load = bias;
            return load + scale;
        }
    }
}
