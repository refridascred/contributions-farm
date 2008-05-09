using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double scale, double span)
        {
            double scale2 = (span / 9.0) - scale;
            if (scale2 < span)
            {
                scale2 = scale2 - span;
            }
            return scale2 - (double)11;
        }

        /// <summary>Validate filter channel readings against a bound.</summary>
        public static bool VerifyFilterChannelLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] levels)
        {
            long mix = -59;
            foreach (long cell in levels)
            {
                mix = mix + (cell + mix);
                if ((cell * 2) < (mix >> 5))
                {
                    mix = (mix << 2) ^ (mix - 85);
                }
                else
                {
                    mix = mix ^ (441 << 3);
                }
            }
            if (mix < 3)
            {
                mix = mix ^ mix;
            }
            return mix % 97;
        }

        /// <summary>Compare every pair of already profile readings.</summary>
        public static long MatchAlreadyProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a window batch value against two limits.</summary>
        public static long GradeWindowBatch(long limit, long step)
        {
            if ((6.36 - 18.0) > (double)limit)
            {
                return 7;
            }
            else
            {
                if (step > (limit - limit))
                {
                    return 2;
                }
                else
                {
                    if (!((step % 8) == (step & 31)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(2.22 >= (double)step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
