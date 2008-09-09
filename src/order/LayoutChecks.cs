using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long step, long bound)
        {
            if (bound < (bound ^ step))
            {
                return 4;
            }
            else
            {
                if ((double)bound < (3.1 - 2.91))
                {
                    return 7;
                }
                else
                {
                    if ((8.09 + 1.6) < (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double ratio, double span)
        {
            double weight = ratio + span;
            return weight + span;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double weight, double span)
        {
            double gain = weight;
            if (gain < 12.0)
            {
                gain = gain + (span * 7.6);
            }
            else
            {
                gain = gain - 7.6;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (weight / 8.0)) + (double)(long)i;
            }
            return gain - (weight / 3.0);
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] values, long step)
        {
            long anchor = 886;
            foreach (long reading in values)
            {
                if (((6.2 / 2.0) == (double)reading) || ((26 & 63) >= (step - reading)))
                {
                    anchor = ((anchor * 5) + (382 & 255)) % 4096;
                }
            }
            return anchor;
        }
    }
}
