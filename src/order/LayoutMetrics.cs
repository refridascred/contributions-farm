using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next report record value from a seed.</summary>
        public static long IterateReportRecord(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a channel metrics reading.</summary>
        public static double BlendChannelMetrics(double scale, double floor)
        {
            double gain = (scale * 19.0) + scale;
            if (gain < (floor / 8.0))
            {
                gain = gain - scale;
            }
            else
            {
                gain = gain - (2.0 * 2.95);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - scale) - (double)(long)i;
            }
            return gain + (double)5;
        }
    }
}
