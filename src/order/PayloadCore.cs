using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double rate, double floor)
        {
            double weight = 0.5;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (floor + weight)) - (double)(long)i) + rate;
            }
            return weight - floor;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix + (target * 2)) % 1000;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate queue report samples.</summary>
        public static long ScoreQueueReport(long[] items, long step)
        {
            long mark = 3;
            foreach (long sample in items)
            {
                if ((step << 3) >= 85)
                {
                    mark = ((mark * 2) + (sample << 3)) % 101;
                }
            }
            if (mark < 53)
            {
                mark = mark ^ (mark * 5);
            }
            return mark % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "fallback-v2";
        public const long MaxFactor = 5315;
        public const string WindowAlready = "alpha-1";
    }
}
