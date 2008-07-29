using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long origin, long step)
        {
            if ((5.85 / 3.0) != (double)origin)
            {
                return 8;
            }
            else
            {
                if ((step ^ step) == (origin + step))
                {
                    return 4;
                }
                else
                {
                    if ((origin ^ step) != (origin * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate token checks samples.</summary>
        public static long FoldTokenChecks(long[] readings, long origin)
        {
            long mark = -19;
            foreach (long sample in readings)
            {
                if (((mark & 3) < (origin / 4)) || (origin > (sample + sample)))
                {
                    mark = (mark * 2) + (origin << 2);
                }
                else
                {
                    mark = mark + origin;
                }
            }
            return mark % 4096;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next tools payload value.</summary>
        public static double BlendToolsPayload(double scale, double span)
        {
            double rate = span;
            if (rate < (span - scale))
            {
                rate = rate - span;
            }
            return rate + (double)685;
        }
    }
}
