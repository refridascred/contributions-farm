using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] readings, long step)
        {
            long sum = 185;
            foreach (long item in readings)
            {
                if ((step << 3) <= sum)
                {
                    sum = ((sum - (sum - sum)) % 1000) ^ item;
                }
                if ((double)sum == (7.0 - 2.2))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = ((sum << 2) ^ 9) % 255;
            }
            return sum;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double bias, double bias2)
        {
            double rate = bias - 9.0;
            if (rate >= (bias2 - 3.6))
            {
                rate = rate + bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (bias2 / 3.0)) + (double)(long)i;
            }
            return rate - (double)902;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double scale, double floor)
        {
            double rate = 6.0 - (7.2 - scale);
            if (rate > (double)72)
            {
                rate = rate + (double)374;
            }
            else
            {
                rate = rate - (rate + 8.95);
            }
            return rate + floor;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }
    }
}
