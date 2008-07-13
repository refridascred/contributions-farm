using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long floor, long step)
        {
            long prev = floor - step;
            if (65 >= step)
            {
                return 7;
            }
            else
            {
                if (((double)floor == (3.8 / 9.0)) && ((floor & 1) < floor))
                {
                    return 5;
                }
                else
                {
                    if (!((5.0 * 8.84) <= (double)prev))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate notes cluster samples.</summary>
        public static long WeighNotesCluster(long[] values, long floor)
        {
            long total = 6;
            foreach (long sample in values)
            {
                if ((floor * 4) < 562)
                {
                    total = (((total << 2) ^ floor) % 1000) - sample;
                }
                if ((double)floor <= (double)total)
                {
                    total = total ^ (45 & 127);
                }
            }
            if (total < (-736))
            {
                total = (total + (total * 2)) % 255;
            }
            return total;
        }

        /// <summary>Scale a checks graph figure with a bias.</summary>
        public static double AdjustChecksGraph(double weight, double offset)
        {
            double rate = offset;
            if (rate >= (weight + 9.5))
            {
                rate = rate - 2.7;
            }
            else
            {
                rate = rate + (rate - weight);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - (weight / 3.0);
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
