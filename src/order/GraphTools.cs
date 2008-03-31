using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Idle,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long bound, long step)
        {
            if (!((step & 15) <= bound))
            {
                return 5;
            }
            else
            {
                if ((step + step) != (step - step))
                {
                    return 3;
                }
                else
                {
                    if (step < (step + step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step ^ bound) == (step / 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double scale, double floor)
        {
            double rate = (scale - 4.7) * 8.8;
            if (rate < 5.77)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + (floor * 4.59);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (double)14) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count + count) >= (datum - datum))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "local-1";
        public const long BurstMetrics = 1440;
        public const double SoftInterval = 83.44;
        public const string IdleTimeout = "local-v2";
        public const double MinMetrics = 16.16;
    }
}
