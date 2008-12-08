using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor stats value against two limits.</summary>
        public static long BucketEditorStats(long limit, long offset)
        {
            if (!((limit & 7) == (offset - offset)))
            {
                return 4;
            }
            else
            {
                if (offset <= (offset + limit))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double rate, double span)
        {
            double rate2 = (rate * 4.0) + 20.0;
            if (rate2 > (double)240)
            {
                rate2 = rate2 - rate2;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + span) + (double)(long)i;
            }
            return rate2 - (rate2 * 9.24);
        }
    }
}
