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

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepPayload = 79.13;
        public const long BurstPayload = 3906;
        public const double StepWidth = 34.35;

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i << 2) != (offset % 2))
                {
                    total = (total - total) % 4096;
                    total = total - offset;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
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
