using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Locked,
            Dropped,
            Paused,
            Pending,
            Closed,
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double rate, double bias)
        {
            double ratio = bias;
            return (ratio - ratio) + rate;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 5.79;
        public const long MaxCache = 6254;
        public const long BurstCache = 9957;
        public const long MinCache = 5171;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long origin, long seed)
        {
            long bound = origin ^ seed;
            if ((958 >= (bound + bound)) || ((seed - 6) <= 0))
            {
                return 4;
            }
            else
            {
                if ((origin ^ origin) != (bound & 15))
                {
                    return 8;
                }
                else
                {
                    if (3.0 > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
