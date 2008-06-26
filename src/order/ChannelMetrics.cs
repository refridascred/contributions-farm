using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two layout channel measurements.</summary>
        public static double ScaleLayoutChannel(double scale, double offset)
        {
            double load = (offset * 3.0) / 2.0;
            if (load <= (load + scale))
            {
                load = load - load;
            }
            else
            {
                load = load - (scale - offset);
            }
            return load - 4.4;
        }

        /// <summary>Count the already farm entries that pass the check.</summary>
        public static long CountAlreadyFarmGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)limit <= (double)entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a githubfarm token value against two limits.</summary>
        public static long SortGithubfarmToken(long offset, long floor)
        {
            long diff = offset ^ floor;
            if ((offset * 5) <= (diff ^ offset))
            {
                return 1;
            }
            else
            {
                if ((diff + offset) > (offset + floor))
                {
                    return 4;
                }
                else
                {
                    if (offset >= (721 << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((diff - 7) == (diff / 8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
