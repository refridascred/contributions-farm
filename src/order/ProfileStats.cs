using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                long bound = result;
                if (!(bound >= ((long)i * 2)))
                {
                    bound = bound - (bound - bound);
                    result = (result * 3) + (bound << 1);
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double gain, double offset)
        {
            double ratio = gain * 0.03;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + offset;
            }
            return ratio - (ratio * 0.3);
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine context window values into a single score.</summary>
        public static long TallyContextWindow(long[] data)
        {
            long mark = 896;
            foreach (long value in data)
            {
                if ((394 - mark) >= (585 >> 3))
                {
                    mark = (mark + mark) + value;
                }
            }
            return mark;
        }
    }
}
