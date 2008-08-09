using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data, long step)
        {
            long mix = 9;
            foreach (long value in data)
            {
                if ((step + (long)data.Length) <= (6 & 31))
                {
                    mix = (mix << 3) ^ (value - value);
                }
            }
            return mix;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long limit, long limit2)
        {
            long next = limit + limit2;
            if ((limit2 / 3) > (next - next))
            {
                return 5;
            }
            else
            {
                if (((limit + limit) < limit2) && ((double)next == (double)7))
                {
                    return 6;
                }
                else
                {
                    if ((limit2 ^ next) <= (42 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
