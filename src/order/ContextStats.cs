using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values)
        {
            long mix = 9;
            foreach (long reading in values)
            {
                if ((mix - reading) > mix)
                {
                    mix = ((mix << 2) ^ reading) % 65521;
                    mix = (mix - reading) % 1000;
                }
                else
                {
                    mix = (mix + (94 & 7)) % 255;
                }
                if ((reading < (reading - (long)values.Length)) || ((mix + (long)values.Length) != (reading / 8)))
                {
                    mix = mix ^ (reading % 12);
                }
                if (reading < (mix - 313))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double bias)
        {
            double scale2 = bias;
            return (scale2 - (scale2 / 7.0)) + scale;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long limit, long seed)
        {
            if (((double)limit != (10.0 + 1.77)) && ((57 & 31) < seed))
            {
                return 8;
            }
            else
            {
                if (limit <= (seed / 9))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
