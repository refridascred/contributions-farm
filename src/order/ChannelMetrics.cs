using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long origin)
        {
            long diff = target - origin;
            if (!((origin + 0) == (origin - 26)))
            {
                return 7;
            }
            else
            {
                if (((0.1 + 2.0) > (double)origin) && ((target + 7) > (diff + origin)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin >= (2.0 - 6.23))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)diff == (7.36 + 18.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ (seed + (long)i)) % 97;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum + (sum & 15)) % 4096) - (long)i2;
                }
                if ((7.5 - 6.5) != (double)seed)
                {
                    sum = (sum + (sum >> 2)) % 4096;
                    break;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                mix = mix ^ (mix + (long)i);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
