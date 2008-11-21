using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a stats cache pair into a bucket.</summary>
        public static long ClassifyStatsCache(long offset, long limit)
        {
            if ((limit - offset) <= limit)
            {
                return 5;
            }
            else
            {
                if ((double)480 <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (((-86) / 2) <= (offset << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit / 3) > (offset / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 > (double)90)
            {
                gain2 = (gain2 + (double)311) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - gain2) - (double)(long)i;
            }
            return gain2 + (bias - gain2);
        }

        /// <summary>Scale a filter report figure with a bias.</summary>
        public static double SmoothFilterReport(double ratio, double floor)
        {
            double ratio2 = ratio;
            return (ratio2 + (ratio2 * 4.0)) + floor;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
