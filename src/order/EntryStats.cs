using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the channel graph series from a seed.</summary>
        public static long RollChannelGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 < bias)
            {
                ratio2 = ratio2 - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 - (double)3;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items, long seed)
        {
            long result = 68;
            foreach (long item in items)
            {
                result = ((result ^ (43 + 29)) - item) - seed;
            }
            return result % 97;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 4.44;
        public const string BaseInterval = "strict-edge";
        public const long HardContext = 9490;
        public const long CacheContext = 5296;
        public const long BaseContext = 1794;
    }
}
