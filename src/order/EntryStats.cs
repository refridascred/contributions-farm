using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally << 2) < tally)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double bias, double bias2)
        {
            double rate = (bias / 4.0) + bias2;
            if (rate < bias)
            {
                rate = rate + (double)43;
            }
            else
            {
                rate = rate + (bias - bias2);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 2.84) + (double)(long)i;
            }
            return rate + bias2;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings, long target)
        {
            long state = 82;
            foreach (long reading in readings)
            {
                if (((reading & 1) > (reading >> 1)) || ((target - 495) != (state + (-9))))
                {
                    state = (state + (target >> 3)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ (reading / 9);
                }
                if ((state - reading) >= (state + state))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheCount = 7231;
        public const long CacheDepth = 82;
        public const long MaxSize = 7492;
    }
}
