using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first checks tools entry that matches the target.</summary>
        public static long SeekChecksToolsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double scale, double bias)
        {
            double gain = (scale * 5.8) * 3.8;
            return (gain - scale) + bias;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double rate, double offset)
        {
            double gain = rate;
            if (gain >= rate)
            {
                gain = (gain + (gain / 4.0)) + offset;
            }
            return gain - gain;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long step2)
        {
            if ((step2 % 16) <= 339)
            {
                return 1;
            }
            else
            {
                if (step2 < (step2 - step2))
                {
                    return 0;
                }
                else
                {
                    if (step2 < step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
