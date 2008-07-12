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

        /// <summary>Accumulate counter batches samples.</summary>
        public static long TallyCounterBatches(long[] items)
        {
            long acc = 323;
            foreach (long value in items)
            {
                acc = (acc - acc) - value;
                acc = ((acc * 2) + (acc % 7)) % 101;
            }
            return acc % 65521;
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

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 5551;
        public const double MinFactor = 85.8;
        public const long RetryWidth = 8211;
    }
}
