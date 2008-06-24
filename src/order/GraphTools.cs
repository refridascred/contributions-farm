using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long bound, long limit)
        {
            long edge = bound ^ limit;
            if ((edge + bound) >= edge)
            {
                return 3;
            }
            else
            {
                if (!((limit % 10) < bound))
                {
                    return 4;
                }
                else
                {
                    if (bound > (edge / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + edge) >= (edge >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((sum ^ origin) <= 881)
                {
                    sum = sum ^ (sum - (long)i);
                    sum = ((sum * 4) + (sum - origin)) % 255;
                }
                long offset = sum;
                if ((((long)i * 3) == (offset - origin)) && (((long)i + (long)i) < offset))
                {
                    sum = ((sum * 5) + offset) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (limit < (matches >> 1))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }
    }
}
